using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using DevIO.App.Extentions;
using Microsoft.AspNetCore.Mvc;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace DevIO.App.Controllers
{
    [Authorize]
    public class ProdutosController : BaseController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository,
                                  IProdutoService produtoService,
                                  IFornecedorRepository fornecedorRepository,
                                  IMapper mapper, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [Route("lista-de-produtos")]
        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosFornecedores()));
        }

        [AllowAnonymous]
        [Route("dados-do-produtos/{id:guid}")]
        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produto", "Adicionar")]
        [Route("novo-produto")]
        // GET: Produtos/Create
        public async Task<IActionResult> Create()
        {
            var vmodel = await PopularFornecedores(new ProdutoViewModel());
            return View(vmodel);
        }

        [ClaimsAuthorize("Produto", "Adicionar")]
        [Route("novo-produto")]
        // POST: Produtos/Create
        [HttpPost]
        public async Task<IActionResult> Create(ProdutoViewModel vmodel)
        {
            vmodel = await PopularFornecedores(vmodel);
            if (!ModelState.IsValid) return View(vmodel);

            var imgPrefixo = $"{Guid.NewGuid()}_";
            if (!await UploadArquivo(vmodel.ImagemUpload, imgPrefixo)) return View(vmodel);

            vmodel.Imagem = imgPrefixo + vmodel.ImagemUpload.FileName;

            await _produtoService.Adicionar(_mapper.Map<Produto>(vmodel));

            if (!OperacaoValida()) return View(vmodel);

            return RedirectToAction("Index");
        }

        [ClaimsAuthorize("Produto", "Editar")]
        [Route("editar-produto/{id:guid}")]
        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }
            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produto", "Editar")]
        [Route("editar-produto/{id:guid}")]
        // POST: Produtos/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel vmodel)
        {
            if (id != vmodel.Id) return NotFound();

            var vmodelAtualizacao = await ObterProduto(id);
            vmodel.Fornecedor = vmodelAtualizacao.Fornecedor;
            vmodel.Imagem = vmodelAtualizacao.Imagem;
            
            if (!ModelState.IsValid) return View(vmodel);

            if (vmodel.ImagemUpload != null)
            {
                var imgPrefixo = $"{Guid.NewGuid()}_";
                if (!await UploadArquivo(vmodel.ImagemUpload, imgPrefixo)) return View(vmodel);
                vmodelAtualizacao.Imagem = imgPrefixo + vmodel.ImagemUpload.FileName;
            }

            vmodelAtualizacao.Nome = vmodel.Nome;
            vmodelAtualizacao.Descricao = vmodel.Descricao;
            vmodelAtualizacao.Valor = vmodel.Valor;
            vmodelAtualizacao.Ativo = vmodel.Ativo;

            await _produtoService.Atualizar(_mapper.Map<Produto>(vmodelAtualizacao));

            if (!OperacaoValida()) return View(vmodel);

            return RedirectToAction("Index");
        }

        [ClaimsAuthorize("Produto", "Excluir")]
        [Route("excluir-produto/{id:guid}")]
        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produto", "Excluir")]
        [Route("excluir-produto/{id:guid}")]
        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            await _produtoService.Remover(id);
            if (!OperacaoValida()) return View(produtoViewModel);


            TempData["Sucesso"] = "Produto Excluido com Sucesso!";

            return RedirectToAction("Index");
        }

        private async Task<ProdutoViewModel> ObterProduto(Guid id)
        {
            var vmodel = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoFornecedor(id));
            //if (vmodel == null) return null;
            //vmodel = await PopularFornecedores(vmodel);
            return vmodel;
        }

        private async Task<ProdutoViewModel> PopularFornecedores(ProdutoViewModel vmodel)
        {
            vmodel.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return vmodel;
        }

        private async Task<bool> UploadArquivo(IFormFile arquivo, string imgPrefixo)
        {
            if ((arquivo?.Length ?? 0) <= 0) return false;

            var path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot/imagens", imgPrefixo + arquivo.FileName);
            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe arquivo com esse nome");
                return false;
            }

            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Create))
            {
                await arquivo.CopyToAsync(stream);
            }

            return true;
        }
    }
}

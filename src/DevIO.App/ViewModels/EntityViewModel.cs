using System;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class EntityViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
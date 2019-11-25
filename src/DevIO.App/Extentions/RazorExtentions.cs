using System;
using Microsoft.AspNetCore.Mvc.Razor;

namespace DevIO.App.Extentions
{
    public static class RazorExtentions
    {
        public static string FormataDocumento(this RazorPage page, string documento)
        {
            return string.IsNullOrEmpty(documento) ? documento 
                   : documento.Length == 11 ? Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00") 
                   : Convert.ToUInt64(documento).ToString(@"00\.000\.000\/0000\-00");
        }
    }
}
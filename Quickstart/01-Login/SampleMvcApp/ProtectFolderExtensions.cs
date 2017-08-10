using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace SampleMvcApp
{
  public static class ProtectFolderExtensions {
    public static IApplicationBuilder UseProtectFolder(
      this IApplicationBuilder builder,
      ProtectFolderOptions options ) {
      return builder.UseMiddleware<ProtectFolder>( options );
    }
  }
}

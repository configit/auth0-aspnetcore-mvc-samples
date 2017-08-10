using Microsoft.AspNetCore.Http;

namespace SampleMvcApp {
  public class ProtectFolderOptions {
    public PathString Path { get; set; }
    public string PolicyName { get; set; }
  }
}

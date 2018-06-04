using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using ShaderTools.VisualStudio.LanguageServices;

namespace ShaderTools.Editor.VisualStudio
{
    [InstalledProductRegistration("#110", "#112", ShaderToolsPackage.Version, IconResourceID = 400)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [Guid("5A45E451-3706-4C2C-B472-AC569CEB7F43")]
    internal sealed class SetupPackage : Package
    {
    }


    //严重性	代码	说明	项目	文件	行	禁止显示状态
    //错误 CreatePkgDef : error : ProvideBindingRedirectionAttribute: Invalid value specified for NewVersion.ShaderTools.Editor.VisualStudio

}

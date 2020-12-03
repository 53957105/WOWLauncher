using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// 程序的一些声明信息
[assembly: AssemblyTitle("幻想魔兽登陆器")]
[assembly: AssemblyDescription("启动魔兽")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("幻想魔兽登陆器")]
[assembly: AssemblyProduct("幻想魔兽登陆器")]
[assembly: AssemblyCopyright("Copyright © 幻想魔兽 2020")]
[assembly: AssemblyTrademark("幻想魔兽登陆器")]
[assembly: AssemblyCulture("")]

// 具有false在程序中不可见 
// 用于COM组件。 如果要通过此组件访问该类型
// COM, 将此类型的ComVisible属性设置为TRUE。
[assembly: ComVisible(false)]

//要开始构建本地化应用程序，请指定
// .csproj文件中的<UICulture> CultureYouAreCodingWith</ UICulture>
//在<PropertyGroup>中。 例如，如果您使用的是英国美国
//在其源文件中，将<UICulture>设置为en-US。 然后撤消转换为评论
//下面的NeutralResourceLanguage属性。 更新“en-US”
//在底部排，以确保UICulture设置与项目文件匹配。

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,
    //特定主题的资源字典在哪里
    //（如果在页面上找不到资源，则使用此选项
    //或在应用程序资源字典中）
    ResourceDictionaryLocation.SourceAssembly
    //特定主题的资源字典在哪里
    //（如果在页面上找不到资源，则使用此选项
    //或在应用程序资源字典中）
)]


    //程序集的版本信息包含以下四个值：
    //
    //主版本号
    //附加版本号
    //构建号码
    //修订版
    //
    //默认情况下，您可以设置所有值或接受程序集编号和修订号
    //使用“*”，如下所示：
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2.4.0.2")]
[assembly: AssemblyFileVersion("2.4.0.2")]
[assembly: GuidAttribute("F37E84CB-D76A-49B1-A1AC-88879903087B")]

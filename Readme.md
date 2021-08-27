<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1863)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [HelpHelper.cs](./CS/WindowsApplication1/HelpHelper.cs) (VB: [HelpHelper.vb](./VB/WindowsApplication1/HelpHelper.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to make the HelpRequested event work for editors with DisableTextEditor style?


<p>The HelpRequested event doesn't fire if the control's style is ControlStyles.ContainerControl. You can find the detailed information in the <a href="https://www.devexpress.com/Support/Center/p/K18286">Why the HelpRequested event isn't raised for some DevExpress editors?</a> Knowledge Base article. This example demonstrates how you can implement your custom helper class to overcome this problem.</p>

<br/>



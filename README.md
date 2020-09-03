# AutoUpdater
# ![AutoUpdater](AutoUpdater.PNG)

AutoUpdater is a library which allows developers to easily add auto update feature to their desktop (Windows, macOS and Linux) application. 

This project has been migrated from CodePlex and isn't actively maintained. It's provided for archival purposes only.
You can find the original page [https://archive.codeplex.com/?p=autoupdater](https://archive.codeplex.com/?p=autoupdater)  

I'm currently working on a cross-platform project which will support Platforms Android, iOS, Windows, MacOs. Linux, for Android and iOS, there have built-in auto update feature to use, but for Windows, MacOs, Linux, I found my previous open source project which I built in 10 years ago and got around 1 million downloads in Codeplex for last ten years  still works, as Codeplex has been stopped, I migrate it from Codeplex to Github and will continue to maintain this repository, issues here.

# Description

Fixing bugs and adding new features is a part of developing software applications. From my experience, sending application updates to users is also a critical part of developing applications, especially when the user has no advanced knowledge of computers. 

In the Internet era today, the software developer must make application deployment and updating easier and often makes automatic application updates to do this.I already searched through the internet on this topic, but not much seems suited to my needs. So, I tried to create one myself. 

This sample application is developed in C# as a library with the project name “AutoUpdater”. The DLL “AutoUpdater” can be used in a C# Windows application (WinForm, WPF, UWP and Xamarin).

# About the features

### There are certain features about the AutoUpdater:

1. Easy to implement and use.  
2. Application automatic re-run after checking update.  
3. Update process transparent to the user .  
4. To avoid blocking the main thread using multi-threaded download.  
5. Ability to upgrade the system and also the auto update program.  
6. A code that doesn't need change when used by different systems and could be compiled in a library.  
7. Easy for user to download the update files.

# The following UI

There are two pages and very pretty simple,just as follows:

![autoupdatersolution_4](https://github.com/knightswarrior/AppAutoUpdater/blob/master/autoupdatersolution_4.png)

Figure 1

![autoupdatersolution_5](https://github.com/knightswarrior/AppAutoUpdater/blob/master/autoupdatersolution_5.png)

Figure 2

# How to use?

In the program that you want to be auto updateable, you just need to call the AutoUpdate function in the Main procedure. The AutoUpdate  function will check the version with the one read from a file located in a Web Site/FTP. If the program version is lower than the one read the program downloads the auto update program and launches it and the function returns True, which means that an auto update will run and the current program should be closed. The auto update program receives several parameters from the program to be updated and performs the auto update necessary and after that launches the updated system.

<pre>      #region check and download <span style="color: #0000ff;">new</span> version program
      <span style="color: #0000ff;">bool</span> bHasError = <span style="color: #0000ff;">false</span>;
      IAutoUpdater autoUpdater = <span style="color: #0000ff;">new</span> AutoUpdater();
      <span style="color: #0000ff;">try</span>
      {
          autoUpdater.Update();
      }
      <span style="color: #0000ff;">catch</span> (WebException exp)
      {
          MessageBox.Show("<span style="color: #8b0000;">Can not find the specified resource</span>");
          bHasError = <span style="color: #0000ff;">true</span>;
      }
      <span style="color: #0000ff;">catch</span> (XmlException exp)
      {
          bHasError = <span style="color: #0000ff;">true</span>;
          MessageBox.Show("<span style="color: #8b0000;">Download the upgrade file error</span>");
      }
      <span style="color: #0000ff;">catch</span> (NotSupportedException exp)
      {
          bHasError = <span style="color: #0000ff;">true</span>;
          MessageBox.Show("<span style="color: #8b0000;">Upgrade address configuration error</span>");
      }
      <span style="color: #0000ff;">catch</span> (ArgumentException exp)
      {
          bHasError = <span style="color: #0000ff;">true</span>;
          MessageBox.Show("<span style="color: #8b0000;">Download the upgrade file error</span>");
      }
      <span style="color: #0000ff;">catch</span> (Exception exp)
      {
          bHasError = <span style="color: #0000ff;">true</span>;
          MessageBox.Show("<span style="color: #8b0000;">An error occurred during the upgrade process</span>");
      }
      <span style="color: #0000ff;">finally</span>
      {
          <span style="color: #0000ff;">if</span> (bHasError == <span style="color: #0000ff;">true</span>)
          {
              <span style="color: #0000ff;">try</span>
              {
                  autoUpdater.RollBack();
              }
              <span style="color: #0000ff;">catch</span> (Exception)
              {
                 <span style="color: #008000;">//Log the message to your file or database</span>
              }
          }
      }
      #endregion</pre>

That’s all and just enjoy it!

# About the solutions

The application is pretty simple,just contains two pages and some helper classes.

![autoupdatersolution_1](https://github.com/knightswarrior/AppAutoUpdater/blob/master/autoupdatersolution_1.png)

Figure 3

# License

This article has no explicit license attached to it but may contain usage terms in the article text or the download files themselves. If in doubt please contact the author via the discussion board below.

# About the Author

*   Author: 圣殿骑士（Knights Warrior）
*   Email:  [KnightsWarrior@msn.com](mailto:KnightsWarrior@msn.com)
*   Website:  [http://www.cnblogs.com/KnightsWarrior/](http://www.cnblogs.com/KnightsWarrior/)           [https://github.com/knightswarrior/AppAutoUpdater/](http://knightswarrior.blog.51cto.com/)
*   Created Date: 5/8/2010
*   Updated Date: 8/10/2020


you can download the tool via [https://github.com/knightswarrior/AppAutoUpdater/](https://github.com/knightswarrior/AppAutoUpdater/ "https://github.com/knightswarrior/AppAutoUpdater/"),If in doubt please contact me,Thanks!

</div>

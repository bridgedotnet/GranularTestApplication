# GranularTestApplication

A development project for Granular

### GranularTestApplication.sln structure
1. GranularTestApplication - Source Wpf application.
2. GranularTestApplication.Wpf - Reference windows application that uses a Wpf application host.
3. GranularTestApplication.Web - Reference web application that uses a Web application host, and compiles with Bridge.

### Build
Before opening the solution, initialize **Granular** submodule
```
git submodule init
git submodule update
```

Note that the reference projects **GranularTestApplication.Wpf**, and **GranularTestApplication.Web** have to be rebuilt for every change in the source project **GranularTestApplication**, you can unload projects under **Granular** or **Granular.Web** folders respectively in order to speed up the build.

For more details on how to develop and test new features in Granular, take a look at the [Developers Guide](https://github.com/yuvaltz/Granular/wiki/Developers-guide).

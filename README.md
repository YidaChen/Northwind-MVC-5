## 使用Northwind資料庫(LocalDB)和asp.net mvc 5，寫一個有CRUD功能的頁面:

建立好專案後，在App_Data新增LocalDB(mdf檔)，並執行SQL資料夾裡的sql，以建立 Northwind 相關 Table 與資料。

在Models中以Database First建立ADO.NET實體資料模型，以產生Northwind.edmx和映射的Table類別。

使用Scaffold對Product.cs建立具有View、使用Entity Framework的Controller後，對Product資料表的CRUD功能與頁面已完成。

將在Controller對DBEntities的Product資料表的操作抽離出來成Repository類別，以符合關注點分離和單一職責原則的思想。因為也許在別的Controller也會有對Product執行相同的操作，所以不同Controller能共用Repository，以避免程式的重複撰寫(DRY)。

Controller透過Repository類別來進行資料的存取，在Controller裡就不再需要考慮到對資料庫的存取操作，只需要考慮流程控制與資料的正確與否。

參考資源:

[初學 ASP.NET MVC 藉由 Scaffold 認識 C.R.U.D 的操作](http://kevintsengtw.blogspot.tw/2015/04/aspnet-mvc-scaffold-crud.html)

[ASP.NET MVC 專案分層架構 Part.1 初學者的起手式](http://kevintsengtw.blogspot.tw/2012/10/aspnet-mvc-part1.html)


[ASP.NET MVC 單元測試系列 (1)：新手上路 / 開始撰寫！](https://blog.miniasp.com/post/2010/09/14/ASPNET-MVC-Unit-Testing-Part-01-Kick-off.aspx)

[Mocking Entity Framework when Unit Testing ASP.NET Web API 2](https://docs.microsoft.com/en-us/aspnet/web-api/overview/testing-and-debugging/mocking-entity-framework-when-unit-testing-aspnet-web-api-2)

[ASP.NET MVC 單元測試系列 (3)：瞭解 Mock 假物件 ( moq )](https://blog.miniasp.com/post/2010/09/16/ASPNET-MVC-Unit-Testing-Part-03-Using-Mock-moq.aspx)

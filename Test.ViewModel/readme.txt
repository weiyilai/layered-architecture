MVC -> MVVM

Model View ViewModel

因為 model <-> view 只能一對一
但是頁面通常有一對一 一對多的資料或是更複雜的處理
ViewModel 創建多個類別
此時MVC專案的Model就可以將會用到的ViewModel類別全部宣告在一個Model檔
再藉由Model全部丟到View做處理
或是由View接收資料到Controller

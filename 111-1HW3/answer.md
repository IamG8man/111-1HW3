﻿# 第2次作業-作業-HW2
>
>學號：109111128
><br />
>姓名：林奕璋
><br />
>作業撰寫時間：180 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/10/12
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容

開始寫說明，該說明需說明想法，
並於之後再對上述想法的每一部分將程式進一步進行展現，
若需引用程式區則使用下面方法，
若為.cs檔內程式除了於敘述中需註明檔案名稱外，
還需使用語法` ```csharp 程式碼 ``` `，
下段程式碼則為使用後結果：

```csharp
public void mt_getResult(){
   public partial class Test : System.Web.UI.Page f
string[] = s_Vegetable = new string[2] {"蔬菜","水果"};
    string[,] s_fruit = new string[2, 2]{{"A菜,“空心菜" },#{“番茄”,"火龍果}
protected void Page_Load(object sender, Eventargs e) {
        if { !IsPostBack} { }
        for (int i_ct = 0; i_ct < A Vegetable.Length; i_Ct++)

{
            ListItem s_v = new ListItem();
            s_V.Text = s_V.Value = s_Vegetable[i_ct];

            dd1_category.Items.Add(s_v);
        }
        mt_GenSecondList();
    }
}
        protected void mt_GenSecondList()
{ 
int i_ind = ddl_Category.SelectedIndex;
        dd1_Food.Items.clear();
for (int i_ct=0; i_ct<s_fruit.GetLength(1); i_ct++) { 
ListItem s_V = new ListItem();
        s_V.Text = s_V.Value = s_fruit[i_ind, i_ct];
        }
}
```

若要於內文中標示部分.aspx檔，則使用以下標籤` ```html 程式碼 ``` `，
下段程式碼則為使用後結果：

```html
<%@ Page Language="C#" AutoEventWireup="true" ...>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" ...>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><asp:DropDownList ID="dd1_Category" runat="server"></asp:DropDownList>
         <div><asp:DropDwonList ID="dd1_Food" runat="server"></asp:DropDwonList>
        
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)
需要了解物件的屬性，了解怎麼用程式碼寫出下拉式選單，還需要了解iteams clear的使用，才能使這項作業完成


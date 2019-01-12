A .NET wrapper for TKUCourseApplication

This is a program to help you on TKU curriculum online system (Include the break captcha).

[Nuget Package Page](https://www.nuget.org/packages/TKUCourseApplication)

[TKU Curriculum Online System(Chinese)](http://www.ais.tku.edu.tw/elecos/)  [TKU Curriculum Online System(English)](http://www.ais.tku.edu.tw/EleCos_English/loginE.aspx)

## Dependencies

### Microsoft .NET Framework 4.5

Since TKUCourseApplication compiled with Visual Studio 2017 you'll need to ensure you have the 
[Microsoft .NET Framework 4.5][.net-runtime] installed.

## Methods

### Chinese Server,English Server

- #### Login()
  `public bool Login(string stu_id, string stu_pwd);`
  	##### Parameters
  	###### stu_id  `string`
   Your student id
  ###### stu_pwd  `string`
  Your student password
  ##### Returns
  ###### `bool`
  Returns `true` if the login was successful, otherwise returns `false`.
- #### AddCourse()
  ` public bool AddCourse(string course_id);`
  ##### Parameters
  ###### course_id  `string`
  Course number
  ##### Returns
  ###### `bool`
  Returns `true` if the course add successful, otherwise returns `false`.
- #### DropCourse()
  ` public bool DropCourse(string course_id);` 
  ##### Parameters
  ###### course_id  `string`
  Course number
  ##### Returns
  ###### `bool`
  Returns `true` if the course drop successful, otherwise returns `false`.

## Examples
### Chinese Server
```c#
TKUCourse.CHT tku = new TKUCourse.CHT();
while (tku.Login("your_student_id", "your_student_password") == false){
    Console.WriteLine("Attempt login...");
}// If success login, return true, else return false

if (tku.AddCourse("1234")){//If add successfully, return true, else return false
    Console.WriteLine("Add : " + s + " Successfully!!");
    }// Display successfully message 
else{
    Console.WriteLine("Add : " + s + " Failed!!");
    }//display failed message
	
if (tku.DropCourse("1234")){//If drop successfully, return true, else return false
    Console.WriteLine("Drop : " + s + " Successfully!!");
    }// Display successfully message 
else{
    Console.WriteLine("Drop : " + s + " Failed!!");
    }//display failed message
```
### English Server
```c#
TKUCourse.ENG tku = new TKUCourse.ENG();
while (tku.Login("your_student_id", "your_student_password") == false){
    Console.WriteLine("Attempt login...");
}// If success login, return true, else return false

if (tku.AddCourse("1234")){//If add successfully, return true, else return false
    Console.WriteLine("Add : " + s + " Successfully!!");
    }// Display successfully message 
else{
    Console.WriteLine("Add : " + s + " Failed!!");
    }//display failed message
	
if (tku.DropCourse("1234")){//If drop successfully, return true, else return false
    Console.WriteLine("Drop : " + s + " Successfully!!");
    }// Display successfully message 
else{
    Console.WriteLine("Drop : " + s + " Failed!!");
    }//display failed message
```


[.net-runtime]:https://www.microsoft.com/zh-tw/download/details.aspx?id=30653

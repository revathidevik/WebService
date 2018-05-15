<%@ WebService Language="C#" class="MyClass" %>

using  System.Web.Services ;

public class MyClass
{
        [WebMethod()]
        public  int Add ( int a,  int  b)
        {
                return a + b ;        
        }
}


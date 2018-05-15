namespace MyWebService
 {
 using System ;
 using System.Web.Services ;

 public class MyStringReverse: WebService
 {
        [WebMethod(Description="Reverse String")]
        public  String ReverseString ( String InString )
        {
                // Check null String
                if ( InString == null )  return null ;
                        
                Int32 intSize = InString.Length ;
                char[] arrayInString = InString.ToCharArray() ;
                char[] arrayOutString = new char[intSize] ;
                for (Int32 i = 0 ; i < intSize ; ++i) 
                        arrayOutString[i] = arrayInString[intSize-i-1] ;
                        
                return new String(arrayOutString) ;        
        }
 }

}


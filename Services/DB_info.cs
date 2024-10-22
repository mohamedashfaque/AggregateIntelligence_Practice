namespace DependInj2.Services;
public class DB_info{
    public string DB_String{get ;set;}
    public int Db_SecretKey{get ;set;}
    public UserInfo userinfo {get;set;}
      public class UserInfo{
        public string User_Name{get ;set;}
        public string User_Password{get ;set;}
    }
}

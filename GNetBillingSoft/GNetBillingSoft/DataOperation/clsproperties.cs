// Type: GNetBillingSoft.DataOperation.clsproperties
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using System;
using System.Data.SqlClient;

namespace GNetBillingSoft.DataOperation
{
  internal class clsproperties
  {
    private static string mvarDbName = "master";
    private static SqlConnection mvarcon = new SqlConnection();
    private static bool mvarboolFinish = false;
    private static bool mvartablefinish = false;
    private static bool mvarbooltrans = false;
    private static string mvarCompanyName;
    private static string mvarcomppath;
    private static string mvarAddress1;
    private static string mvarAddress2;
    private static string mvarCity;
    private static string mvarState;
    private static string mvarCountry;
    private static string mvarTelephone;
    private static string mvarMobile;
    private static string mvarFax;
    private static string mvarEmail;
    private static string mvarzip;
    private static string progressMsg;
    private static DateTime mvardtfrom;
    private static DateTime mvardtto;
    private static string mvardisplayname;
    private static string mvarunit;
    private static string mvarremarks;
    private static string mvaripaddress;
    public static string IPAddress
    {
        get
        {
            return clsproperties.mvaripaddress;
        }
        set
        {
            mvaripaddress = value;
        }
    }
    public static string DisplayName
    {
      get
      {
        return clsproperties.mvardisplayname;
      }
      set
      {
        clsproperties.mvardisplayname = value;
      }
    }

    public static string CompanyName
    {
      get
      {
        return clsproperties.mvarCompanyName;
      }
      set
      {
        clsproperties.mvarCompanyName = value;
      }
    }

    public static string DbName
    {
      get
      {
        return clsproperties.mvarDbName;
      }
      set
      {
        clsproperties.mvarDbName = value;
      }
    }

    public static string CompanyPath
    {
      get
      {
        return clsproperties.mvarcomppath;
      }
      set
      {
        clsproperties.mvarcomppath = value;
      }
    }

    public static SqlConnection CompConnection
    {
      get
      {
        return clsproperties.mvarcon;
      }
      set
      {
        clsproperties.mvarcon = value;
      }
    }

    public static string Addr1
    {
      get
      {
        return clsproperties.mvarAddress1;
      }
      set
      {
        clsproperties.mvarAddress1 = value;
      }
    }

    public static string Addr2
    {
      get
      {
        return clsproperties.mvarAddress2;
      }
      set
      {
        clsproperties.mvarAddress2 = value;
      }
    }

    public static string Telephone
    {
      get
      {
        return clsproperties.mvarTelephone;
      }
      set
      {
        clsproperties.mvarTelephone = value;
      }
    }

    public static string Mobile
    {
      get
      {
        return clsproperties.mvarMobile;
      }
      set
      {
        clsproperties.mvarMobile = value;
      }
    }

    public static string Email
    {
      get
      {
        return clsproperties.mvarEmail;
      }
      set
      {
        clsproperties.mvarEmail = value;
      }
    }

    public static string City
    {
      get
      {
        return clsproperties.mvarCity;
      }
      set
      {
        clsproperties.mvarCity = value;
      }
    }

    public static string State
    {
      get
      {
        return clsproperties.mvarState;
      }
      set
      {
        clsproperties.mvarState = value;
      }
    }

    public static string Zip
    {
      get
      {
        return clsproperties.mvarzip;
      }
      set
      {
        clsproperties.mvarzip = value;
      }
    }

    public static string Country
    {
      get
      {
        return clsproperties.mvarCountry;
      }
      set
      {
        clsproperties.mvarCountry = value;
      }
    }

    public static string Fax
    {
      get
      {
        return clsproperties.mvarFax;
      }
      set
      {
        clsproperties.mvarFax = value;
      }
    }

    public static string PrgMessage
    {
      get
      {
        return clsproperties.progressMsg;
      }
      set
      {
        clsproperties.progressMsg = value;
      }
    }

    public static bool Finish
    {
      get
      {
        return clsproperties.mvarboolFinish;
      }
      set
      {
        clsproperties.mvarboolFinish = value;
      }
    }

    public static bool TableFinish
    {
      get
      {
        return clsproperties.mvartablefinish;
      }
      set
      {
        clsproperties.mvartablefinish = value;
      }
    }

    public static bool BoolTrans
    {
      get
      {
        return clsproperties.mvarbooltrans;
      }
      set
      {
        clsproperties.mvarbooltrans = value;
      }
    }

    public static DateTime DtFrom
    {
      get
      {
        return clsproperties.mvardtfrom;
      }
      set
      {
        clsproperties.mvardtfrom = value;
      }
    }

    public static DateTime DtTo
    {
      get
      {
        return clsproperties.mvardtto;
      }
      set
      {
        clsproperties.mvardtto = value;
      }
    }
    public static string Units
    {
        set
        {
            mvarunit = value;
        }
        get
        {
            return mvarunit;
        }
    }
    public static string Remarks
    {
        set
        {
            mvarremarks = value;
        }
        get
        {
            return mvarremarks;
        }
    }
    static clsproperties()
    {
    }
  }
}

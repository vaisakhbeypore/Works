// Type: GNetBillingSoft.DataOperation.clsvoucherdetails
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using System;
using System.Data;

namespace GNetBillingSoft.DataOperation
{
  public class clsvoucherdetails
  {
    private const string mvartablename = "voucherdetails";
    private long mvarvoucherdetailno;
    private long mvarvoucherno;
    private string mvaraccounttype;
    private string mvarname;
    private string mvarreferenceinv;
    private double mvaramount;
    private string mvarremark;
    private double mvaroldbalance;

    public long voucherdetailno
    {
      get
      {
        return this.mvarvoucherdetailno;
      }
      set
      {
        this.mvarvoucherdetailno = value;
      }
    }

    public long voucherno
    {
      get
      {
        return this.mvarvoucherno;
      }
      set
      {
        this.mvarvoucherno = value;
      }
    }

    public string accounttype
    {
      get
      {
        return this.mvaraccounttype;
      }
      set
      {
        this.mvaraccounttype = value;
      }
    }

    public string name
    {
      get
      {
        return this.mvarname;
      }
      set
      {
        this.mvarname = value;
      }
    }

    public string referenceinv
    {
      get
      {
        return this.mvarreferenceinv;
      }
      set
      {
        this.mvarreferenceinv = value;
      }
    }

    public double amount
    {
      get
      {
        return this.mvaramount;
      }
      set
      {
        this.mvaramount = value;
      }
    }

    public string remark
    {
      get
      {
        return this.mvarremark;
      }
      set
      {
        this.mvarremark = value;
      }
    }

    public double OldBalance
    {
      get
      {
        return this.mvaroldbalance;
      }
      set
      {
        this.mvaroldbalance = value;
      }
    }

    public void Add()
    {
        string strsql = "INSERT INTO voucherdetails([voucherdetailno],[voucherno],[accounttype],[name],[referenceinv],[amount],[remark],[oldbalance]) VALUES  ('" +mvarvoucherdetailno + "','" +mvarvoucherno + "','" + this.mvaraccounttype + "','" + this.mvarname + "','" + this.mvarreferenceinv + "','" + this.mvaramount + "','" + this.mvarremark + "','" + this.mvaroldbalance + "')";
      dboperation.ExecuteSql(strsql);
    }

    public void Edit()
    {
      dboperation.ExecuteSql("update voucherdetails set voucherno='" + (object) this.mvarvoucherno + "',accounttype='" + this.mvaraccounttype + "',name='" + this.mvarname + "',referenceinv='" + this.mvarreferenceinv + "',amount='" + (string) (object) this.mvaramount + "',remark='" + this.mvarremark + "',oldbalance='" + (string) (object) this.mvaroldbalance + "' where   voucherdetailno = " + (string) (object) this.mvarvoucherdetailno);
    }

    public void Delete()
    {
      dboperation.ExecuteSql("Delete from voucherdetails where   voucherdetailno = " + (object) this.mvarvoucherdetailno + " ");
    }

    public void DeletDetails()
    {
      dboperation.ExecuteSql("Delete from voucherdetails where   voucherno = '" + (object) this.mvarvoucherno + "' ");
    }

    public int GetNextId()
    {
      object avalue = dboperation.GetAValue("select max(voucherdetailno) from voucherdetails");
      if (avalue == DBNull.Value)
        return 1;
      else
        return Convert.ToInt32(avalue) + 1;
    }

    public DataTable GetRecord()
    {
      return dboperation.GetDataTable("select voucherdetailno,voucherno,accounttype,name,referenceinv,amount,remark,oldbalance from voucherdetails ");
    }

    public DataTable GetSelRecord()
    {
      return dboperation.GetDataTable("select voucherdetailno,voucherno,accounttype,name,referenceinv,amount,remark,oldbalance from voucherdetails where voucherno='" + (object) this.mvarvoucherno + "' ");
    }

    public bool GetItems()
    {
      bool flag = false;
      if (dboperation.GetDataTable("select * from voucherdetails where voucherdetailno=" + (object) this.mvarvoucherdetailno + " ").Rows.Count > 0)
        flag = true;
      return flag;
    }
  }
}

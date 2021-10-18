using System;
using System.Collections.Generic;
using MongoDB.Bson;  

//Api sonuçları için
public class Result{
  public bool success;
  public List<Stocks> result;
}

///Temettü bilgileri
public class Stocks{
  public double rate;
  public double lastprice;
  public String lastpricestr;
  public  double hacim;
  public String hacimstr;
  public double min;
  public String minstr;
  public double max;
  public String maxstr;
  public String time;
  public String text;
  public String code;
}

/// Temettü 
public class DividendType
{
    public ObjectId _id { get; set; }
    public String Code { get; set; }
    public String Date { get; set; }
    public Double Value { get; set; }
}


/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace teledon
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class CazDTO : TBase
  {
    private string _descriere;
    private double _suma;

    public string Descriere
    {
      get
      {
        return _descriere;
      }
      set
      {
        __isset.descriere = true;
        this._descriere = value;
      }
    }

    public double Suma
    {
      get
      {
        return _suma;
      }
      set
      {
        __isset.suma = true;
        this._suma = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool descriere;
      public bool suma;
    }

    public CazDTO() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Descriere = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Double) {
                Suma = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("CazDTO");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Descriere != null && __isset.descriere) {
          field.Name = "descriere";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Descriere);
          oprot.WriteFieldEnd();
        }
        if (__isset.suma) {
          field.Name = "suma";
          field.Type = TType.Double;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(Suma);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("CazDTO(");
      bool __first = true;
      if (Descriere != null && __isset.descriere) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Descriere: ");
        __sb.Append(Descriere);
      }
      if (__isset.suma) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Suma: ");
        __sb.Append(Suma);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}

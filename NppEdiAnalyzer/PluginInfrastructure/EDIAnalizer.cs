using System;
using System.Collections.Generic;
using System.Text;


public class ComponentStructure
{
    public string sTag { get; set; }
    public string sDescription { get; set; }
    public int iMinlength { get; set; }
    public int iMaxLength { get; set; }
    public string sDataType { get; set; }
    public string sRefTable { get; set; }
    public string sValue { get; set; }

public ComponentStructure(string sTag, string sDescription, int iMinlength, int iMaxLength, string sDataType, string sRefTable, string sValue)
    {
        this.sTag = sTag;
        this.sDescription = sDescription;
        this.iMinlength = iMinlength;
        this.iMaxLength = iMaxLength;
        this.sDataType = sDataType;
        this.sRefTable = sRefTable;
        this.sValue = sValue;
    }
}

public class ElementStructure
{
    public string sTag { get; set; }
    public string sDescription { get; set; }
    public string sValue { get; set; }
    public string sRefTable { get; set; }

    public List<ComponentStructure> ComponentList = new List<ComponentStructure>();

    public ElementStructure(string sTag, string sDescription, string sValue, string sRefTable)
    {
        this.sTag = sTag;
        this.sDescription = sDescription;
        this.sValue = sValue;
        this.sRefTable = sRefTable;
    }
}

public class SegmentStructure
{
    public string sFileName { get; set; }
    public int iLineNumber { get; set; }
    public string sGroup { get; set; }
    public int iGroupNumber { get; set; }
    public string sTag { get; set; }
    public string sDescription { get; set; }

    public List<ElementStructure> ElementsList = new List<ElementStructure>();
    //List<SegmentStructure> SegmentList = new List<SegmentStructure>();

    public SegmentStructure(string sFileName, int iLineNumber, string sGroup, int iGroupNumber, string sTag, string sDescription)
    {
        this.sFileName = sFileName;
        this.iLineNumber = iLineNumber;
        this.sGroup = sGroup;
        this.iGroupNumber = iGroupNumber;
        this.sTag = sTag;
        this.sDescription = sDescription;
        //this.ElementsList = null;

    }




}
/*
public class ComboboxItem
{
    public string Text { get; set; }
    public object Value { get; set; }

    public override string ToString()
    {
        return Text;
    }
}
*/
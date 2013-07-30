﻿using System;



public partial class DelegationsDataContext : Microsoft.SharePoint.Linq.DataContext
{

    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion

    public DelegationsDataContext(string requestUrl) :
        base(requestUrl)
    {
        this.OnCreated();
    }

    /// <summary>
    /// My List Instance
    /// </summary>
    [Microsoft.SharePoint.Linq.ListAttribute(Name = "Delegations")]
    public Microsoft.SharePoint.Linq.EntityList<Delegation> Delegations
    {
        get
        {
            return this.GetList<Delegation>("Delegations");
        }
    }
}

/// <summary>
/// Create a new list item.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name = "Item", Id = "0x01")]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type = typeof(MARTADelegation))]
public partial class Item : Microsoft.SharePoint.Linq.ITrackEntityState, Microsoft.SharePoint.Linq.ITrackOriginalValues, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging
{

    private System.Nullable<int> _id;

    private System.Nullable<int> _version;

    private string _path;

    private Microsoft.SharePoint.Linq.EntityState _entityState;

    private System.Collections.Generic.IDictionary<string, object> _originalValues;

    private string _title;

    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    #endregion

    Microsoft.SharePoint.Linq.EntityState Microsoft.SharePoint.Linq.ITrackEntityState.EntityState
    {
        get
        {
            return this._entityState;
        }
        set
        {
            if ((value != this._entityState))
            {
                this._entityState = value;
            }
        }
    }

    System.Collections.Generic.IDictionary<string, object> Microsoft.SharePoint.Linq.ITrackOriginalValues.OriginalValues
    {
        get
        {
            if ((null == this._originalValues))
            {
                this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
            }
            return this._originalValues;
        }
    }

    public Item()
    {
        this.OnCreated();
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "ID", Storage = "_id", ReadOnly = true, FieldType = "Counter")]
    public System.Nullable<int> Id
    {
        get
        {
            return this._id;
        }
        set
        {
            if ((value != this._id))
            {
                this.OnPropertyChanging("Id", this._id);
                this._id = value;
                this.OnPropertyChanged("Id");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "owshiddenversion", Storage = "_version", ReadOnly = true, FieldType = "Integer")]
    public System.Nullable<int> Version
    {
        get
        {
            return this._version;
        }
        set
        {
            if ((value != this._version))
            {
                this.OnPropertyChanging("Version", this._version);
                this._version = value;
                this.OnPropertyChanged("Version");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "FileDirRef", Storage = "_path", ReadOnly = true, FieldType = "Lookup", IsLookupValue = true)]
    public string Path
    {
        get
        {
            return this._path;
        }
        set
        {
            if ((value != this._path))
            {
                this.OnPropertyChanging("Path", this._path);
                this._path = value;
                this.OnPropertyChanged("Path");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "Title", Storage = "_title", Required = true, FieldType = "Text")]
    public virtual string Title
    {
        get
        {
            return this._title;
        }
        set
        {
            if ((value != this._title))
            {
                this.OnPropertyChanging("Title", this._title);
                this._title = value;
                this.OnPropertyChanged("Title");
            }
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if ((null != this.PropertyChanged))
        {
            this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }

    protected virtual void OnPropertyChanging(string propertyName, object value)
    {
        if ((null == this._originalValues))
        {
            this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
        }
        if ((false == this._originalValues.ContainsKey(propertyName)))
        {
            this._originalValues.Add(propertyName, value);
        }
        if ((null != this.PropertyChanging))
        {
            this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
        }
    }
}

/// <summary>
/// My Content Type
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name = "MARTADelegation", Id = "0x01001444DA97382F4D3BACD45C11AE78769C")]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type = typeof(Delegation))]
public partial class MARTADelegation : Item
{

    private System.Nullable<System.DateTime> _startDate;

    private System.Nullable<System.DateTime> _endDate;

    private System.Nullable<DelegationType> _delegationType;

    private System.Nullable<int> _delegationForId;

    private string _delegationFor;

    private System.Nullable<int> _assignedToId;

    private string _assignedTo;

    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    #endregion

    public MARTADelegation()
    {
        this.OnCreated();
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "DelegationStart", Storage = "_startDate", Required = true, FieldType = "DateTime")]
    public System.Nullable<System.DateTime> StartDate
    {
        get
        {
            return this._startDate;
        }
        set
        {
            if ((value != this._startDate))
            {
                this.OnPropertyChanging("StartDate", this._startDate);
                this._startDate = value;
                this.OnPropertyChanged("StartDate");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "DelegationEnd", Storage = "_endDate", Required = true, FieldType = "DateTime")]
    public System.Nullable<System.DateTime> EndDate
    {
        get
        {
            return this._endDate;
        }
        set
        {
            if ((value != this._endDate))
            {
                this.OnPropertyChanging("EndDate", this._endDate);
                this._endDate = value;
                this.OnPropertyChanged("EndDate");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "DelegationType", Storage = "_delegationType", Required = true, FieldType = "Choice")]
    public System.Nullable<DelegationType> DelegationType
    {
        get
        {
            return this._delegationType;
        }
        set
        {
            if ((value != this._delegationType))
            {
                this.OnPropertyChanging("DelegationType", this._delegationType);
                this._delegationType = value;
                this.OnPropertyChanged("DelegationType");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "DelegationFor", Storage = "_delegationForId", Required = true, FieldType = "User", IsLookupId = true)]
    public System.Nullable<int> DelegationForId
    {
        get
        {
            return this._delegationForId;
        }
        set
        {
            if ((value != this._delegationForId))
            {
                this.OnPropertyChanging("DelegationForId", this._delegationForId);
                this._delegationForId = value;
                this.OnPropertyChanged("DelegationForId");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "DelegationFor", Storage = "_delegationFor", ReadOnly = true, FieldType = "User", IsLookupValue = true)]
    public string DelegationFor
    {
        get
        {
            return this._delegationFor;
        }
        set
        {
            if ((value != this._delegationFor))
            {
                this.OnPropertyChanging("DelegationFor", this._delegationFor);
                this._delegationFor = value;
                this.OnPropertyChanged("DelegationFor");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "AssignedTo", Storage = "_assignedToId", Required = true, FieldType = "User", IsLookupId = true)]
    public System.Nullable<int> AssignedToId
    {
        get
        {
            return this._assignedToId;
        }
        set
        {
            if ((value != this._assignedToId))
            {
                this.OnPropertyChanging("AssignedToId", this._assignedToId);
                this._assignedToId = value;
                this.OnPropertyChanged("AssignedToId");
            }
        }
    }

    [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "AssignedTo", Storage = "_assignedTo", ReadOnly = true, FieldType = "User", IsLookupValue = true)]
    public string AssignedTo
    {
        get
        {
            return this._assignedTo;
        }
        set
        {
            if ((value != this._assignedTo))
            {
                this.OnPropertyChanging("AssignedTo", this._assignedTo);
                this._assignedTo = value;
                this.OnPropertyChanged("AssignedTo");
            }
        }
    }
}

/// <summary>
/// My Content Type
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name = "MARTADelegation", Id = "0x01001444DA97382F4D3BACD45C11AE78769C", List = "Delegations")]
public partial class Delegation : MARTADelegation
{

    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    #endregion

    public Delegation()
    {
        this.OnCreated();
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
    public override string Title
    {
        get
        {
            throw new System.InvalidOperationException("Field Title was removed from content type MARTADelegation.");
        }
        set
        {
            throw new System.InvalidOperationException("Field Title was removed from content type MARTADelegation.");
        }
    }
}

public enum DelegationType : int
{

    None = 0,

    Invalid = 1,

    [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "Legal")]
    Legal = 2,

    [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "Manager")]
    Manager = 4,

    [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "Self")]
    Self = 8,
}
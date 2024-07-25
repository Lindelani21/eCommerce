﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace svc_G
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    partial void InsertCartItem(CartItem instance);
    partial void UpdateCartItem(CartItem instance);
    partial void DeleteCartItem(CartItem instance);
    partial void InsertUserTable(UserTable instance);
    partial void UpdateUserTable(UserTable instance);
    partial void DeleteUserTable(UserTable instance);
    partial void InsertCart(Cart instance);
    partial void UpdateCart(Cart instance);
    partial void DeleteCart(Cart instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertReview(Review instance);
    partial void UpdateReview(Review instance);
    partial void DeleteReview(Review instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<CartItem> CartItems
		{
			get
			{
				return this.GetTable<CartItem>();
			}
		}
		
		public System.Data.Linq.Table<UserTable> UserTables
		{
			get
			{
				return this.GetTable<UserTable>();
			}
		}
		
		public System.Data.Linq.Table<Cart> Carts
		{
			get
			{
				return this.GetTable<Cart>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Review> Reviews
		{
			get
			{
				return this.GetTable<Review>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _InvId;
		
		private int _UserId;
		
		private int _CartId;
		
		private string _Invoice1;
		
		private EntityRef<UserTable> _UserTable;
		
		private EntityRef<Cart> _Cart;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInvIdChanging(int value);
    partial void OnInvIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnCartIdChanging(int value);
    partial void OnCartIdChanged();
    partial void OnInvoice1Changing(string value);
    partial void OnInvoice1Changed();
    #endregion
		
		public Invoice()
		{
			this._UserTable = default(EntityRef<UserTable>);
			this._Cart = default(EntityRef<Cart>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int InvId
		{
			get
			{
				return this._InvId;
			}
			set
			{
				if ((this._InvId != value))
				{
					this.OnInvIdChanging(value);
					this.SendPropertyChanging();
					this._InvId = value;
					this.SendPropertyChanged("InvId");
					this.OnInvIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._UserTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CartId", DbType="Int NOT NULL")]
		public int CartId
		{
			get
			{
				return this._CartId;
			}
			set
			{
				if ((this._CartId != value))
				{
					if (this._Cart.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCartIdChanging(value);
					this.SendPropertyChanging();
					this._CartId = value;
					this.SendPropertyChanged("CartId");
					this.OnCartIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Invoice", Storage="_Invoice1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Invoice1
		{
			get
			{
				return this._Invoice1;
			}
			set
			{
				if ((this._Invoice1 != value))
				{
					this.OnInvoice1Changing(value);
					this.SendPropertyChanging();
					this._Invoice1 = value;
					this.SendPropertyChanged("Invoice1");
					this.OnInvoice1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTable_Invoice", Storage="_UserTable", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public UserTable UserTable
		{
			get
			{
				return this._UserTable.Entity;
			}
			set
			{
				UserTable previousValue = this._UserTable.Entity;
				if (((previousValue != value) 
							|| (this._UserTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserTable.Entity = null;
						previousValue.Invoices.Remove(this);
					}
					this._UserTable.Entity = value;
					if ((value != null))
					{
						value.Invoices.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("UserTable");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cart_Invoice", Storage="_Cart", ThisKey="CartId", OtherKey="CartId", IsForeignKey=true)]
		public Cart Cart
		{
			get
			{
				return this._Cart.Entity;
			}
			set
			{
				Cart previousValue = this._Cart.Entity;
				if (((previousValue != value) 
							|| (this._Cart.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cart.Entity = null;
						previousValue.Invoices.Remove(this);
					}
					this._Cart.Entity = value;
					if ((value != null))
					{
						value.Invoices.Add(this);
						this._CartId = value.CartId;
					}
					else
					{
						this._CartId = default(int);
					}
					this.SendPropertyChanged("Cart");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CartItem")]
	public partial class CartItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemId;
		
		private int _CartId;
		
		private int _ProId;
		
		private int _Quantity;
		
		private EntityRef<Cart> _Cart;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIdChanging(int value);
    partial void OnItemIdChanged();
    partial void OnCartIdChanging(int value);
    partial void OnCartIdChanged();
    partial void OnProIdChanging(int value);
    partial void OnProIdChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
		
		public CartItem()
		{
			this._Cart = default(EntityRef<Cart>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ItemId
		{
			get
			{
				return this._ItemId;
			}
			set
			{
				if ((this._ItemId != value))
				{
					this.OnItemIdChanging(value);
					this.SendPropertyChanging();
					this._ItemId = value;
					this.SendPropertyChanged("ItemId");
					this.OnItemIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CartId", DbType="Int NOT NULL")]
		public int CartId
		{
			get
			{
				return this._CartId;
			}
			set
			{
				if ((this._CartId != value))
				{
					if (this._Cart.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCartIdChanging(value);
					this.SendPropertyChanging();
					this._CartId = value;
					this.SendPropertyChanged("CartId");
					this.OnCartIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProId", DbType="Int NOT NULL")]
		public int ProId
		{
			get
			{
				return this._ProId;
			}
			set
			{
				if ((this._ProId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProIdChanging(value);
					this.SendPropertyChanging();
					this._ProId = value;
					this.SendPropertyChanged("ProId");
					this.OnProIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cart_CartItem", Storage="_Cart", ThisKey="CartId", OtherKey="CartId", IsForeignKey=true)]
		public Cart Cart
		{
			get
			{
				return this._Cart.Entity;
			}
			set
			{
				Cart previousValue = this._Cart.Entity;
				if (((previousValue != value) 
							|| (this._Cart.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cart.Entity = null;
						previousValue.CartItems.Remove(this);
					}
					this._Cart.Entity = value;
					if ((value != null))
					{
						value.CartItems.Add(this);
						this._CartId = value.CartId;
					}
					else
					{
						this._CartId = default(int);
					}
					this.SendPropertyChanged("Cart");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_CartItem", Storage="_Product", ThisKey="ProId", OtherKey="ProId", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.CartItems.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.CartItems.Add(this);
						this._ProId = value.ProId;
					}
					else
					{
						this._ProId = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserTable")]
	public partial class UserTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _UserName;
		
		private string _UserSurname;
		
		private string _UserEmail;
		
		private string _UserPassword;
		
		private string _UserType;
		
		private EntitySet<Invoice> _Invoices;
		
		private EntitySet<Cart> _Carts;
		
		private EntitySet<Review> _Reviews;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnUserSurnameChanging(string value);
    partial void OnUserSurnameChanged();
    partial void OnUserEmailChanging(string value);
    partial void OnUserEmailChanged();
    partial void OnUserPasswordChanging(string value);
    partial void OnUserPasswordChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public UserTable()
		{
			this._Invoices = new EntitySet<Invoice>(new Action<Invoice>(this.attach_Invoices), new Action<Invoice>(this.detach_Invoices));
			this._Carts = new EntitySet<Cart>(new Action<Cart>(this.attach_Carts), new Action<Cart>(this.detach_Carts));
			this._Reviews = new EntitySet<Review>(new Action<Review>(this.attach_Reviews), new Action<Review>(this.detach_Reviews));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserSurname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserSurname
		{
			get
			{
				return this._UserSurname;
			}
			set
			{
				if ((this._UserSurname != value))
				{
					this.OnUserSurnameChanging(value);
					this.SendPropertyChanging();
					this._UserSurname = value;
					this.SendPropertyChanged("UserSurname");
					this.OnUserSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserEmail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserEmail
		{
			get
			{
				return this._UserEmail;
			}
			set
			{
				if ((this._UserEmail != value))
				{
					this.OnUserEmailChanging(value);
					this.SendPropertyChanging();
					this._UserEmail = value;
					this.SendPropertyChanged("UserEmail");
					this.OnUserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserPassword
		{
			get
			{
				return this._UserPassword;
			}
			set
			{
				if ((this._UserPassword != value))
				{
					this.OnUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._UserPassword = value;
					this.SendPropertyChanged("UserPassword");
					this.OnUserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTable_Invoice", Storage="_Invoices", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Invoice> Invoices
		{
			get
			{
				return this._Invoices;
			}
			set
			{
				this._Invoices.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTable_Cart", Storage="_Carts", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Cart> Carts
		{
			get
			{
				return this._Carts;
			}
			set
			{
				this._Carts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTable_Review", Storage="_Reviews", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Review> Reviews
		{
			get
			{
				return this._Reviews;
			}
			set
			{
				this._Reviews.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.UserTable = this;
		}
		
		private void detach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.UserTable = null;
		}
		
		private void attach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.UserTable = this;
		}
		
		private void detach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.UserTable = null;
		}
		
		private void attach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.UserTable = this;
		}
		
		private void detach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.UserTable = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cart")]
	public partial class Cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CartId;
		
		private int _UserId;
		
		private int _TotalCost;
		
		private EntitySet<Invoice> _Invoices;
		
		private EntitySet<CartItem> _CartItems;
		
		private EntityRef<UserTable> _UserTable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCartIdChanging(int value);
    partial void OnCartIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnTotalCostChanging(int value);
    partial void OnTotalCostChanged();
    #endregion
		
		public Cart()
		{
			this._Invoices = new EntitySet<Invoice>(new Action<Invoice>(this.attach_Invoices), new Action<Invoice>(this.detach_Invoices));
			this._CartItems = new EntitySet<CartItem>(new Action<CartItem>(this.attach_CartItems), new Action<CartItem>(this.detach_CartItems));
			this._UserTable = default(EntityRef<UserTable>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CartId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CartId
		{
			get
			{
				return this._CartId;
			}
			set
			{
				if ((this._CartId != value))
				{
					this.OnCartIdChanging(value);
					this.SendPropertyChanging();
					this._CartId = value;
					this.SendPropertyChanged("CartId");
					this.OnCartIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._UserTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalCost", DbType="Int NOT NULL")]
		public int TotalCost
		{
			get
			{
				return this._TotalCost;
			}
			set
			{
				if ((this._TotalCost != value))
				{
					this.OnTotalCostChanging(value);
					this.SendPropertyChanging();
					this._TotalCost = value;
					this.SendPropertyChanged("TotalCost");
					this.OnTotalCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cart_Invoice", Storage="_Invoices", ThisKey="CartId", OtherKey="CartId")]
		public EntitySet<Invoice> Invoices
		{
			get
			{
				return this._Invoices;
			}
			set
			{
				this._Invoices.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cart_CartItem", Storage="_CartItems", ThisKey="CartId", OtherKey="CartId")]
		public EntitySet<CartItem> CartItems
		{
			get
			{
				return this._CartItems;
			}
			set
			{
				this._CartItems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTable_Cart", Storage="_UserTable", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public UserTable UserTable
		{
			get
			{
				return this._UserTable.Entity;
			}
			set
			{
				UserTable previousValue = this._UserTable.Entity;
				if (((previousValue != value) 
							|| (this._UserTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserTable.Entity = null;
						previousValue.Carts.Remove(this);
					}
					this._UserTable.Entity = value;
					if ((value != null))
					{
						value.Carts.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("UserTable");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.Cart = this;
		}
		
		private void detach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.Cart = null;
		}
		
		private void attach_CartItems(CartItem entity)
		{
			this.SendPropertyChanging();
			entity.Cart = this;
		}
		
		private void detach_CartItems(CartItem entity)
		{
			this.SendPropertyChanging();
			entity.Cart = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProId;
		
		private string _ProName;
		
		private int _ProPrice;
		
		private string _ProDescription;
		
		private string _ProCategory;
		
		private string _ProImage;
		
		private EntitySet<CartItem> _CartItems;
		
		private EntitySet<Review> _Reviews;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProIdChanging(int value);
    partial void OnProIdChanged();
    partial void OnProNameChanging(string value);
    partial void OnProNameChanged();
    partial void OnProPriceChanging(int value);
    partial void OnProPriceChanged();
    partial void OnProDescriptionChanging(string value);
    partial void OnProDescriptionChanged();
    partial void OnProCategoryChanging(string value);
    partial void OnProCategoryChanged();
    partial void OnProImageChanging(string value);
    partial void OnProImageChanged();
    #endregion
		
		public Product()
		{
			this._CartItems = new EntitySet<CartItem>(new Action<CartItem>(this.attach_CartItems), new Action<CartItem>(this.detach_CartItems));
			this._Reviews = new EntitySet<Review>(new Action<Review>(this.attach_Reviews), new Action<Review>(this.detach_Reviews));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProId
		{
			get
			{
				return this._ProId;
			}
			set
			{
				if ((this._ProId != value))
				{
					this.OnProIdChanging(value);
					this.SendPropertyChanging();
					this._ProId = value;
					this.SendPropertyChanged("ProId");
					this.OnProIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProName
		{
			get
			{
				return this._ProName;
			}
			set
			{
				if ((this._ProName != value))
				{
					this.OnProNameChanging(value);
					this.SendPropertyChanging();
					this._ProName = value;
					this.SendPropertyChanged("ProName");
					this.OnProNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProPrice", DbType="Int NOT NULL")]
		public int ProPrice
		{
			get
			{
				return this._ProPrice;
			}
			set
			{
				if ((this._ProPrice != value))
				{
					this.OnProPriceChanging(value);
					this.SendPropertyChanging();
					this._ProPrice = value;
					this.SendPropertyChanged("ProPrice");
					this.OnProPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProDescription", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProDescription
		{
			get
			{
				return this._ProDescription;
			}
			set
			{
				if ((this._ProDescription != value))
				{
					this.OnProDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ProDescription = value;
					this.SendPropertyChanged("ProDescription");
					this.OnProDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProCategory", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProCategory
		{
			get
			{
				return this._ProCategory;
			}
			set
			{
				if ((this._ProCategory != value))
				{
					this.OnProCategoryChanging(value);
					this.SendPropertyChanging();
					this._ProCategory = value;
					this.SendPropertyChanged("ProCategory");
					this.OnProCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProImage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ProImage
		{
			get
			{
				return this._ProImage;
			}
			set
			{
				if ((this._ProImage != value))
				{
					this.OnProImageChanging(value);
					this.SendPropertyChanging();
					this._ProImage = value;
					this.SendPropertyChanged("ProImage");
					this.OnProImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_CartItem", Storage="_CartItems", ThisKey="ProId", OtherKey="ProId")]
		public EntitySet<CartItem> CartItems
		{
			get
			{
				return this._CartItems;
			}
			set
			{
				this._CartItems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Review", Storage="_Reviews", ThisKey="ProId", OtherKey="ProId")]
		public EntitySet<Review> Reviews
		{
			get
			{
				return this._Reviews;
			}
			set
			{
				this._Reviews.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CartItems(CartItem entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_CartItems(CartItem entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Review")]
	public partial class Review : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RevId;
		
		private int _UserId;
		
		private int _ProId;
		
		private string _review1;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<UserTable> _UserTable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRevIdChanging(int value);
    partial void OnRevIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnProIdChanging(int value);
    partial void OnProIdChanged();
    partial void Onreview1Changing(string value);
    partial void Onreview1Changed();
    #endregion
		
		public Review()
		{
			this._Product = default(EntityRef<Product>);
			this._UserTable = default(EntityRef<UserTable>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RevId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RevId
		{
			get
			{
				return this._RevId;
			}
			set
			{
				if ((this._RevId != value))
				{
					this.OnRevIdChanging(value);
					this.SendPropertyChanging();
					this._RevId = value;
					this.SendPropertyChanged("RevId");
					this.OnRevIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._UserTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProId", DbType="Int NOT NULL")]
		public int ProId
		{
			get
			{
				return this._ProId;
			}
			set
			{
				if ((this._ProId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProIdChanging(value);
					this.SendPropertyChanging();
					this._ProId = value;
					this.SendPropertyChanged("ProId");
					this.OnProIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="review", Storage="_review1", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string review1
		{
			get
			{
				return this._review1;
			}
			set
			{
				if ((this._review1 != value))
				{
					this.Onreview1Changing(value);
					this.SendPropertyChanging();
					this._review1 = value;
					this.SendPropertyChanged("review1");
					this.Onreview1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Review", Storage="_Product", ThisKey="ProId", OtherKey="ProId", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Reviews.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Reviews.Add(this);
						this._ProId = value.ProId;
					}
					else
					{
						this._ProId = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTable_Review", Storage="_UserTable", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public UserTable UserTable
		{
			get
			{
				return this._UserTable.Entity;
			}
			set
			{
				UserTable previousValue = this._UserTable.Entity;
				if (((previousValue != value) 
							|| (this._UserTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserTable.Entity = null;
						previousValue.Reviews.Remove(this);
					}
					this._UserTable.Entity = value;
					if ((value != null))
					{
						value.Reviews.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("UserTable");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591

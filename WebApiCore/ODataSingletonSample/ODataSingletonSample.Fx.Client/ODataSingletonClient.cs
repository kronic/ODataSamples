//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/27/2018 2:11:54 PM
namespace ODataSingletonSample.Fx.Client
{
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Container")]
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "ODataSingletonSample", "ODataSingletonSample.Fx.Client");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("ODataSingletonSample.Fx.Client", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("ODataSingletonSample.", originalNameAttribute.OriginalName);
                }
                return string.Concat("ODataSingletonSample.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Employees")]
        public global::Microsoft.OData.Client.DataServiceQuery<Employee> Employees
        {
            get
            {
                if ((this._Employees == null))
                {
                    this._Employees = base.CreateQuery<Employee>("Employees");
                }
                return this._Employees;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Employee> _Employees;
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
        /// <summary>
        /// There are no comments for Umbrella in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Umbrella")]
        public CompanySingle Umbrella
        {
            get
            {
                if ((this._Umbrella == null))
                {
                    this._Umbrella = new CompanySingle(this, "Umbrella");
                }
                return this._Umbrella;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private CompanySingle _Umbrella;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""ODataSingletonSample"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Employee"">
        <Key>
          <PropertyRef Name=""ID"" />
        </Key>
        <Property Name=""ID"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
        <NavigationProperty Name=""Company"" Type=""ODataSingletonSample.Company"" />
      </EntityType>
      <EntityType Name=""Company"">
        <Key>
          <PropertyRef Name=""ID"" />
        </Key>
        <Property Name=""ID"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
        <Property Name=""Revenue"" Type=""Edm.Int64"" Nullable=""false"" />
        <Property Name=""Category"" Type=""ODataSingletonSample.CompanyCategory"" Nullable=""false"" />
        <NavigationProperty Name=""Employees"" Type=""Collection(ODataSingletonSample.Employee)"" />
      </EntityType>
      <EnumType Name=""CompanyCategory"">
        <Member Name=""IT"" Value=""0"" />
        <Member Name=""Communication"" Value=""1"" />
        <Member Name=""Electronics"" Value=""2"" />
        <Member Name=""Others"" Value=""3"" />
      </EnumType>
      <Action Name=""ResetDataSource"" IsBound=""true"">
        <Parameter Name=""bindingParameter"" Type=""Collection(ODataSingletonSample.Employee)"" />
      </Action>
      <Action Name=""ResetDataSource"" IsBound=""true"">
        <Parameter Name=""bindingParameter"" Type=""ODataSingletonSample.Company"" />
      </Action>
      <Function Name=""GetEmployeesCount"" IsBound=""true"">
        <Parameter Name=""bindingParameter"" Type=""ODataSingletonSample.Company"" />
        <ReturnType Type=""Edm.Int32"" Nullable=""false"" />
      </Function>
      <EntityContainer Name=""Container"">
        <EntitySet Name=""Employees"" EntityType=""ODataSingletonSample.Employee"">
          <NavigationPropertyBinding Path=""Company"" Target=""Umbrella"" />
        </EntitySet>
        <Singleton Name=""Umbrella"" Type=""ODataSingletonSample.Company"">
          <NavigationPropertyBinding Path=""Employees"" Target=""Employees"" />
        </Singleton>
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    global::System.Collections.Generic.IEnumerable<global::Microsoft.OData.Edm.Validation.EdmError> errors;
                    global::Microsoft.OData.Edm.IEdmModel edmModel;
                    
                    if (!global::Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, true, out edmModel, out errors))
                    {
                        global::System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();
                        foreach (var error in errors)
                        {
                            errorMessages.Append(error.ErrorMessage);
                            errorMessages.Append("; ");
                        }
                        throw new global::System.InvalidOperationException(errorMessages.ToString());
                    }

                    return edmModel;
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for EmployeeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeSingle")]
    public partial class EmployeeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Employee>
    {
        /// <summary>
        /// Initialize a new EmployeeSingle object.
        /// </summary>
        public EmployeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmployeeSingle object.
        /// </summary>
        public EmployeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmployeeSingle object.
        /// </summary>
        public EmployeeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Employee> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
        public global::ODataSingletonSample.Fx.Client.CompanySingle Company
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Company == null))
                {
                    this._Company = new global::ODataSingletonSample.Fx.Client.CompanySingle(this.Context, GetPath("Company"));
                }
                return this._Company;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private global::ODataSingletonSample.Fx.Client.CompanySingle _Company;
    }
    /// <summary>
    /// There are no comments for Employee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ID")]
    [global::Microsoft.OData.Client.EntitySet("Employees")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Employee")]
    public partial class Employee : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        public static Employee CreateEmployee(int ID)
        {
            Employee employee = new Employee();
            employee.ID = ID;
            return employee;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ID")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
        public global::ODataSingletonSample.Fx.Client.Company Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private global::ODataSingletonSample.Fx.Client.Company _Company;
        partial void OnCompanyChanging(global::ODataSingletonSample.Fx.Client.Company value);
        partial void OnCompanyChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for CompanySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompanySingle")]
    public partial class CompanySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Company>
    {
        /// <summary>
        /// Initialize a new CompanySingle object.
        /// </summary>
        public CompanySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompanySingle object.
        /// </summary>
        public CompanySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompanySingle object.
        /// </summary>
        public CompanySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Company> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Employees")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::ODataSingletonSample.Fx.Client.Employee> Employees
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employees == null))
                {
                    this._Employees = Context.CreateQuery<global::ODataSingletonSample.Fx.Client.Employee>(GetPath("Employees"));
                }
                return this._Employees;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::ODataSingletonSample.Fx.Client.Employee> _Employees;
    }
    /// <summary>
    /// There are no comments for Company in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ID")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
    public partial class Company : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Company object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="revenue">Initial value of Revenue.</param>
        /// <param name="category">Initial value of Category.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        public static Company CreateCompany(int ID, long revenue, global::ODataSingletonSample.Fx.Client.CompanyCategory category)
        {
            Company company = new Company();
            company.ID = ID;
            company.Revenue = revenue;
            company.Category = category;
            return company;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ID")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Revenue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Revenue")]
        public long Revenue
        {
            get
            {
                return this._Revenue;
            }
            set
            {
                this.OnRevenueChanging(value);
                this._Revenue = value;
                this.OnRevenueChanged();
                this.OnPropertyChanged("Revenue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private long _Revenue;
        partial void OnRevenueChanging(long value);
        partial void OnRevenueChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Category")]
        public global::ODataSingletonSample.Fx.Client.CompanyCategory Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private global::ODataSingletonSample.Fx.Client.CompanyCategory _Category;
        partial void OnCategoryChanging(global::ODataSingletonSample.Fx.Client.CompanyCategory value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Employees")]
        public global::Microsoft.OData.Client.DataServiceCollection<global::ODataSingletonSample.Fx.Client.Employee> Employees
        {
            get
            {
                return this._Employees;
            }
            set
            {
                this.OnEmployeesChanging(value);
                this._Employees = value;
                this.OnEmployeesChanged();
                this.OnPropertyChanged("Employees");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::ODataSingletonSample.Fx.Client.Employee> _Employees = new global::Microsoft.OData.Client.DataServiceCollection<global::ODataSingletonSample.Fx.Client.Employee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmployeesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::ODataSingletonSample.Fx.Client.Employee> value);
        partial void OnEmployeesChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        /// <summary>
        /// There are no comments for GetEmployeesCount in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetEmployeesCount")]
        public global::Microsoft.OData.Client.DataServiceQuerySingle<int> GetEmployeesCount()
        {
            global::System.Uri requestUri;
            Context.TryGetUri(this, out requestUri);

            return this.Context.CreateFunctionQuerySingle<int>(string.Join("/", global::System.Linq.Enumerable.Select(global::System.Linq.Enumerable.Skip(requestUri.Segments, this.Context.BaseUri.Segments.Length), s => s.Trim('/'))), "ODataSingletonSample.GetEmployeesCount", false);
        }
        /// <summary>
        /// There are no comments for ResetDataSource in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("ResetDataSource")]
        public global::Microsoft.OData.Client.DataServiceActionQuery ResetDataSource()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/ODataSingletonSample.ResetDataSource");
        }
    }
    /// <summary>
    /// There are no comments for CompanyCategory in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyCategory")]
    public enum CompanyCategory
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("IT")]
        IT = 0,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Communication")]
        Communication = 1,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Electronics")]
        Electronics = 2,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Others")]
        Others = 3
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::ODataSingletonSample.Fx.Client.Employee as global::ODataSingletonSample.Fx.Client.EmployeeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::ODataSingletonSample.Fx.Client.EmployeeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataSingletonSample.Fx.Client.Employee> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::ODataSingletonSample.Fx.Client.EmployeeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::ODataSingletonSample.Fx.Client.Employee as global::ODataSingletonSample.Fx.Client.EmployeeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="iD">The value of iD</param>
        public static global::ODataSingletonSample.Fx.Client.EmployeeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataSingletonSample.Fx.Client.Employee> source,
            int iD)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "ID", iD }
            };
            return new global::ODataSingletonSample.Fx.Client.EmployeeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::ODataSingletonSample.Fx.Client.Company as global::ODataSingletonSample.Fx.Client.CompanySingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::ODataSingletonSample.Fx.Client.CompanySingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataSingletonSample.Fx.Client.Company> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::ODataSingletonSample.Fx.Client.CompanySingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::ODataSingletonSample.Fx.Client.Company as global::ODataSingletonSample.Fx.Client.CompanySingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="iD">The value of iD</param>
        public static global::ODataSingletonSample.Fx.Client.CompanySingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataSingletonSample.Fx.Client.Company> source,
            int iD)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "ID", iD }
            };
            return new global::ODataSingletonSample.Fx.Client.CompanySingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// There are no comments for GetEmployeesCount in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetEmployeesCount")]
        public static global::Microsoft.OData.Client.DataServiceQuerySingle<int> GetEmployeesCount(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::ODataSingletonSample.Fx.Client.Company> source)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return source.CreateFunctionQuerySingle<int>("ODataSingletonSample.GetEmployeesCount", false);
        }
        /// <summary>
        /// There are no comments for ResetDataSource in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("ResetDataSource")]
        public static global::Microsoft.OData.Client.DataServiceActionQuery ResetDataSource(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataSingletonSample.Fx.Client.Employee> source)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(source.Context, source.AppendRequestUri("ODataSingletonSample.ResetDataSource"));
        }
        /// <summary>
        /// There are no comments for ResetDataSource in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("ResetDataSource")]
        public static global::Microsoft.OData.Client.DataServiceActionQuery ResetDataSource(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::ODataSingletonSample.Fx.Client.Company> source)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(source.Context, source.AppendRequestUri("ODataSingletonSample.ResetDataSource"));
        }
    }
}

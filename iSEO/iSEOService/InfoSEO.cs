namespace iSEO.iSEOService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.Serialization;
    using System.Threading;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name="InfoSEO", Namespace="http://tempuri.org/")]
    public class InfoSEO : IExtensibleDataObject, INotifyPropertyChanged
    {
        [NonSerialized]
        private ExtensionDataObject extensionDataObject_0;
        [OptionalField]
        private string UserIDField;
        [OptionalField]
        private string EmailField;
        [OptionalField]
        private string PasswordField;
        [OptionalField]
        private string PermissionField;
        [OptionalField]
        private string WebsiteField;
        [OptionalField]
        private string ListUserField;
        [OptionalField]
        private string CPUIDField;
        [OptionalField]
        private string MessageField;
        private int ClickStatusField;
        private int iCoinField;
        private int ClickField;
        private PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                while (true)
                {
                    PropertyChangedEventHandler comparand = propertyChanged;
                    PropertyChangedEventHandler handler3 = comparand + value;
                    propertyChanged = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, handler3, comparand);
                    if (ReferenceEquals(propertyChanged, comparand))
                    {
                        return;
                    }
                }
            }
            remove
            {
                PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                while (true)
                {
                    PropertyChangedEventHandler comparand = propertyChanged;
                    PropertyChangedEventHandler handler3 = comparand - value;
                    propertyChanged = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, handler3, comparand);
                    if (ReferenceEquals(propertyChanged, comparand))
                    {
                        return;
                    }
                }
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [Browsable(false)]
        public ExtensionDataObject ExtensionData
        {
            get => 
                this.extensionDataObject_0;
            set => 
                this.extensionDataObject_0 = value;
        }

        [DataMember(EmitDefaultValue=false)]
        public string UserID
        {
            get => 
                this.UserIDField;
            set
            {
                if (!ReferenceEquals(this.UserIDField, value))
                {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }

        [DataMember(EmitDefaultValue=false, Order=1)]
        public string Email
        {
            get => 
                this.EmailField;
            set
            {
                if (!ReferenceEquals(this.EmailField, value))
                {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }

        [DataMember(EmitDefaultValue=false, Order=2)]
        public string Password
        {
            get => 
                this.PasswordField;
            set
            {
                if (!ReferenceEquals(this.PasswordField, value))
                {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }

        [DataMember(EmitDefaultValue=false, Order=3)]
        public string Permission
        {
            get => 
                this.PermissionField;
            set
            {
                if (!ReferenceEquals(this.PermissionField, value))
                {
                    this.PermissionField = value;
                    this.RaisePropertyChanged("Permission");
                }
            }
        }

        [DataMember(EmitDefaultValue=false, Order=4)]
        public string Website
        {
            get => 
                this.WebsiteField;
            set
            {
                if (!ReferenceEquals(this.WebsiteField, value))
                {
                    this.WebsiteField = value;
                    this.RaisePropertyChanged("Website");
                }
            }
        }

        [DataMember(EmitDefaultValue=false, Order=5)]
        public string ListUser
        {
            get => 
                this.ListUserField;
            set
            {
                if (!ReferenceEquals(this.ListUserField, value))
                {
                    this.ListUserField = value;
                    this.RaisePropertyChanged("ListUser");
                }
            }
        }

        [DataMember(EmitDefaultValue=false, Order=6)]
        public string CPUID
        {
            get => 
                this.CPUIDField;
            set
            {
                if (!ReferenceEquals(this.CPUIDField, value))
                {
                    this.CPUIDField = value;
                    this.RaisePropertyChanged("CPUID");
                }
            }
        }

        [DataMember(EmitDefaultValue=false, Order=7)]
        public string Message
        {
            get => 
                this.MessageField;
            set
            {
                if (!ReferenceEquals(this.MessageField, value))
                {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }

        [DataMember(IsRequired=true, Order=8)]
        public int ClickStatus
        {
            get => 
                this.ClickStatusField;
            set
            {
                if (!this.ClickStatusField.Equals(value))
                {
                    this.ClickStatusField = value;
                    this.RaisePropertyChanged("ClickStatus");
                }
            }
        }

        [DataMember(IsRequired=true, Order=9)]
        public int iCoin
        {
            get => 
                this.iCoinField;
            set
            {
                if (!this.iCoinField.Equals(value))
                {
                    this.iCoinField = value;
                    this.RaisePropertyChanged("iCoin");
                }
            }
        }

        [DataMember(IsRequired=true, Order=10)]
        public int Click
        {
            get => 
                this.ClickField;
            set
            {
                if (!this.ClickField.Equals(value))
                {
                    this.ClickField = value;
                    this.RaisePropertyChanged("Click");
                }
            }
        }
    }
}


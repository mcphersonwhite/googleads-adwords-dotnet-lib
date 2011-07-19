// Copyright 2011, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Author: api.anash@gmail.com (Anash P. Oommen)

namespace Google.Api.Ads.AdWords.v13 {
  using Google.Api.Ads.AdWords.Lib;

  using System;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Xml.Serialization;
  using System.Web.Services;
  using System.Web.Services.Protocols;

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AccountServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class AccountService : LegacyAdWordsSoapClient {
    private useragent useragentValueField;

    private password passwordValueField;

    private email emailValueField;

    private clientEmail clientEmailValueField;

    private clientCustomerId clientCustomerIdValueField;

    private developerToken developerTokenValueField;

    private applicationToken applicationTokenValueField;

    private responseTime responseTimeValueField;

    private operations operationsValueField;

    private units unitsValueField;

    private requestId requestIdValueField;

    public AccountService() {
      this.Url = "https://adwords.google.com/api/adwords/v13/AccountService";
    }

    public useragent useragentValue {
      get {
        return this.useragentValueField;
      }
      set {
        this.useragentValueField = value;
      }
    }

    public password passwordValue {
      get {
        return this.passwordValueField;
      }
      set {
        this.passwordValueField = value;
      }
    }

    public email emailValue {
      get {
        return this.emailValueField;
      }
      set {
        this.emailValueField = value;
      }
    }

    public clientEmail clientEmailValue {
      get {
        return this.clientEmailValueField;
      }
      set {
        this.clientEmailValueField = value;
      }
    }

    public clientCustomerId clientCustomerIdValue {
      get {
        return this.clientCustomerIdValueField;
      }
      set {
        this.clientCustomerIdValueField = value;
      }
    }

    public developerToken developerTokenValue {
      get {
        return this.developerTokenValueField;
      }
      set {
        this.developerTokenValueField = value;
      }
    }

    public applicationToken applicationTokenValue {
      get {
        return this.applicationTokenValueField;
      }
      set {
        this.applicationTokenValueField = value;
      }
    }

    public responseTime responseTimeValue {
      get {
        return this.responseTimeValueField;
      }
      set {
        this.responseTimeValueField = value;
      }
    }

    public operations operationsValue {
      get {
        return this.operationsValueField;
      }
      set {
        this.operationsValueField = value;
      }
    }

    public units unitsValue {
      get {
        return this.unitsValueField;
      }
      set {
        this.unitsValueField = value;
      }
    }

    public requestId requestIdValue {
      get {
        return this.requestIdValueField;
      }
      set {
        this.requestIdValueField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getAccountInfoReturn")]
    public AccountInfo getAccountInfo() {
      object[] results = this.Invoke("getAccountInfo", new object[0]);
      return ((AccountInfo) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getClientAccountInfosReturn")]
    public ClientAccountInfo[] getClientAccountInfos() {
      object[] results = this.Invoke("getClientAccountInfos", new object[0]);
      return ((ClientAccountInfo[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getClientAccountsReturn")]
    public string[] getClientAccounts() {
      object[] results = this.Invoke("getClientAccounts", new object[0]);
      return ((string[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getMccAlertsReturn")]
    public MccAlert[] getMccAlerts() {
      object[] results = this.Invoke("getMccAlerts", new object[0]);
      return ((MccAlert[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void updateAccountInfo(AccountInfo accountInfo) {
      this.Invoke("updateAccountInfo", new object[] {accountInfo});
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class clientEmail : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class password : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class responseTime : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class email : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class requestId : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class units : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class developerToken : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class applicationToken : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class operations : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class useragent : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://adwords.google.com/api/adwords/v13", IsNullable = false)]
  public partial class clientCustomerId : System.Web.Services.Protocols.SoapHeader {
    private string[] valueField;

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class AccountInfo {
    private Address billingAddressField;

    private string currencyCodeField;

    private long? customerIdField;

    private bool customerIdFieldSpecified;

    private NetworkType[] defaultNetworkTargetingField;

    private string descriptiveNameField;

    private EmailPromotionsPreferences emailPromotionsPreferencesField;

    private string languagePreferenceField;

    private Address primaryAddressField;

    private string primaryBusinessCategoryField;

    private long? timeZoneEffectiveDateField;

    private bool timeZoneEffectiveDateFieldSpecified;

    private string timeZoneIdField;

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public Address billingAddress {
      get {
        return this.billingAddressField;
      }
      set {
        this.billingAddressField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string currencyCode {
      get {
        return this.currencyCodeField;
      }
      set {
        this.currencyCodeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public long? customerId {
      get {
        return this.customerIdField;
      }
      set {
        this.customerIdField = value;
        this.customerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool customerIdSpecified {
      get {
        return this.customerIdFieldSpecified;
      }
      set {
        this.customerIdFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
    [System.Xml.Serialization.XmlArrayItemAttribute("networkTypes", IsNullable = false)]
    public NetworkType[] defaultNetworkTargeting {
      get {
        return this.defaultNetworkTargetingField;
      }
      set {
        this.defaultNetworkTargetingField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string descriptiveName {
      get {
        return this.descriptiveNameField;
      }
      set {
        this.descriptiveNameField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public EmailPromotionsPreferences emailPromotionsPreferences {
      get {
        return this.emailPromotionsPreferencesField;
      }
      set {
        this.emailPromotionsPreferencesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string languagePreference {
      get {
        return this.languagePreferenceField;
      }
      set {
        this.languagePreferenceField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public Address primaryAddress {
      get {
        return this.primaryAddressField;
      }
      set {
        this.primaryAddressField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string primaryBusinessCategory {
      get {
        return this.primaryBusinessCategoryField;
      }
      set {
        this.primaryBusinessCategoryField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public long? timeZoneEffectiveDate {
      get {
        return this.timeZoneEffectiveDateField;
      }
      set {
        this.timeZoneEffectiveDateField = value;
        this.timeZoneEffectiveDateSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool timeZoneEffectiveDateSpecified {
      get {
        return this.timeZoneEffectiveDateFieldSpecified;
      }
      set {
        this.timeZoneEffectiveDateFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string timeZoneId {
      get {
        return this.timeZoneIdField;
      }
      set {
        this.timeZoneIdField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class Address {
    private string addressLine1Field;

    private string addressLine2Field;

    private string cityField;

    private string companyNameField;

    private string countryCodeField;

    private string emailAddressField;

    private string faxNumberField;

    private string nameField;

    private string phoneNumberField;

    private string postalCodeField;

    private string stateField;

    public string addressLine1 {
      get {
        return this.addressLine1Field;
      }
      set {
        this.addressLine1Field = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string addressLine2 {
      get {
        return this.addressLine2Field;
      }
      set {
        this.addressLine2Field = value;
      }
    }

    public string city {
      get {
        return this.cityField;
      }
      set {
        this.cityField = value;
      }
    }

    public string companyName {
      get {
        return this.companyNameField;
      }
      set {
        this.companyNameField = value;
      }
    }

    public string countryCode {
      get {
        return this.countryCodeField;
      }
      set {
        this.countryCodeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string emailAddress {
      get {
        return this.emailAddressField;
      }
      set {
        this.emailAddressField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string faxNumber {
      get {
        return this.faxNumberField;
      }
      set {
        this.faxNumberField = value;
      }
    }

    public string name {
      get {
        return this.nameField;
      }
      set {
        this.nameField = value;
      }
    }

    public string phoneNumber {
      get {
        return this.phoneNumberField;
      }
      set {
        this.phoneNumberField = value;
      }
    }

    public string postalCode {
      get {
        return this.postalCodeField;
      }
      set {
        this.postalCodeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string state {
      get {
        return this.stateField;
      }
      set {
        this.stateField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class MccAlert {
    private string clientCompanyNameField;

    private long clientCustomerIdField;

    private string clientLoginField;

    private string clientNameField;

    private MccAlertPriority priorityField;

    private System.DateTime triggerTimeField;

    private MccAlertType typeField;

    public string clientCompanyName {
      get {
        return this.clientCompanyNameField;
      }
      set {
        this.clientCompanyNameField = value;
      }
    }

    public long clientCustomerId {
      get {
        return this.clientCustomerIdField;
      }
      set {
        this.clientCustomerIdField = value;
      }
    }

    public string clientLogin {
      get {
        return this.clientLoginField;
      }
      set {
        this.clientLoginField = value;
      }
    }

    public string clientName {
      get {
        return this.clientNameField;
      }
      set {
        this.clientNameField = value;
      }
    }

    public MccAlertPriority priority {
      get {
        return this.priorityField;
      }
      set {
        this.priorityField = value;
      }
    }

    public System.DateTime triggerTime {
      get {
        return this.triggerTimeField;
      }
      set {
        this.triggerTimeField = value;
      }
    }

    public MccAlertType type {
      get {
        return this.typeField;
      }
      set {
        this.typeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum MccAlertPriority {
    Low,
    High
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum MccAlertType {
    AccountOnTarget,
    DeclinedPayment,
    CreditCardExpiring,
    AccountBudgetEnding,
    CampaignEnding,
    CreativeDisapproved,
    PaymentNotEntered,
    MissingBankReferenceNumber,
    CampaignEnded,
    KeywordBelowMinCpc,
    AccountBudgetBurnRate
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class ClientAccountInfo {
    private string emailAddressField;

    private bool isCustomerManagerField;

    public string emailAddress {
      get {
        return this.emailAddressField;
      }
      set {
        this.emailAddressField = value;
      }
    }

    public bool isCustomerManager {
      get {
        return this.isCustomerManagerField;
      }
      set {
        this.isCustomerManagerField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class EmailPromotionsPreferences {
    private bool accountPerformanceEnabledField;

    private bool disapprovedAdsEnabledField;

    private bool marketResearchEnabledField;

    private bool newsletterEnabledField;

    private bool promotionsEnabledField;

    public bool accountPerformanceEnabled {
      get {
        return this.accountPerformanceEnabledField;
      }
      set {
        this.accountPerformanceEnabledField = value;
      }
    }

    public bool disapprovedAdsEnabled {
      get {
        return this.disapprovedAdsEnabledField;
      }
      set {
        this.disapprovedAdsEnabledField = value;
      }
    }

    public bool marketResearchEnabled {
      get {
        return this.marketResearchEnabledField;
      }
      set {
        this.marketResearchEnabledField = value;
      }
    }

    public bool newsletterEnabled {
      get {
        return this.newsletterEnabledField;
      }
      set {
        this.newsletterEnabledField = value;
      }
    }

    public bool promotionsEnabled {
      get {
        return this.promotionsEnabledField;
      }
      set {
        this.promotionsEnabledField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum NetworkType {
    GoogleSearch,
    SearchNetwork,
    ContentNetwork
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ReportServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class ReportService : LegacyAdWordsSoapClient {
    private useragent useragentValueField;

    private password passwordValueField;

    private email emailValueField;

    private clientEmail clientEmailValueField;

    private clientCustomerId clientCustomerIdValueField;

    private developerToken developerTokenValueField;

    private applicationToken applicationTokenValueField;

    private responseTime responseTimeValueField;

    private operations operationsValueField;

    private units unitsValueField;

    private requestId requestIdValueField;

    public ReportService() {
      this.Url = "https://adwords.google.com/api/adwords/v13/ReportService";
    }

    public useragent useragentValue {
      get {
        return this.useragentValueField;
      }
      set {
        this.useragentValueField = value;
      }
    }

    public password passwordValue {
      get {
        return this.passwordValueField;
      }
      set {
        this.passwordValueField = value;
      }
    }

    public email emailValue {
      get {
        return this.emailValueField;
      }
      set {
        this.emailValueField = value;
      }
    }

    public clientEmail clientEmailValue {
      get {
        return this.clientEmailValueField;
      }
      set {
        this.clientEmailValueField = value;
      }
    }

    public clientCustomerId clientCustomerIdValue {
      get {
        return this.clientCustomerIdValueField;
      }
      set {
        this.clientCustomerIdValueField = value;
      }
    }

    public developerToken developerTokenValue {
      get {
        return this.developerTokenValueField;
      }
      set {
        this.developerTokenValueField = value;
      }
    }

    public applicationToken applicationTokenValue {
      get {
        return this.applicationTokenValueField;
      }
      set {
        this.applicationTokenValueField = value;
      }
    }

    public responseTime responseTimeValue {
      get {
        return this.responseTimeValueField;
      }
      set {
        this.responseTimeValueField = value;
      }
    }

    public operations operationsValue {
      get {
        return this.operationsValueField;
      }
      set {
        this.operationsValueField = value;
      }
    }

    public units unitsValue {
      get {
        return this.unitsValueField;
      }
      set {
        this.unitsValueField = value;
      }
    }

    public requestId requestIdValue {
      get {
        return this.requestIdValueField;
      }
      set {
        this.requestIdValueField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void deleteReport(long reportJobId) {
      this.Invoke("deleteReport", new object[] {reportJobId});
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getAllJobsReturn")]
    public ReportJob[] getAllJobs() {
      object[] results = this.Invoke("getAllJobs", new object[0]);
      return ((ReportJob[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getGzipReportDownloadUrlReturn")]
    public string getGzipReportDownloadUrl(long reportJobId) {
      object[] results = this.Invoke("getGzipReportDownloadUrl", new object[] {reportJobId});
      return ((string) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getReportDownloadUrlReturn")]
    public string getReportDownloadUrl(long reportJobId) {
      object[] results = this.Invoke("getReportDownloadUrl", new object[] {reportJobId});
      return ((string) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("getReportJobStatusReturn")]
    public ReportJobStatus getReportJobStatus(long reportJobId) {
      object[] results = this.Invoke("getReportJobStatus", new object[] {reportJobId});
      return ((ReportJobStatus) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("scheduleReportJobReturn")]
    public long scheduleReportJob(ReportJob job) {
      object[] results = this.Invoke("scheduleReportJob", new object[] {job});
      return ((long) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void validateReportJob(ReportJob job) {
      this.Invoke("validateReportJob", new object[] {job});
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinedReportJob))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public abstract partial class ReportJob {
    private string[] clientEmailsField;

    private bool crossClientField;

    private bool crossClientFieldSpecified;

    private System.DateTime? endDayField;

    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private System.DateTime? startDayField;

    private ReportJobStatus statusField;

    private bool statusFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("clientEmails")]
    public string[] clientEmails {
      get {
        return this.clientEmailsField;
      }
      set {
        this.clientEmailsField = value;
      }
    }

    public bool crossClient {
      get {
        return this.crossClientField;
      }
      set {
        this.crossClientField = value;
        this.crossClientSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool crossClientSpecified {
      get {
        return this.crossClientFieldSpecified;
      }
      set {
        this.crossClientFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime? endDay {
      get {
        return this.endDayField;
      }
      set {
        this.endDayField = value;
      }
    }

    public long id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }

    public string name {
      get {
        return this.nameField;
      }
      set {
        this.nameField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime? startDay {
      get {
        return this.startDayField;
      }
      set {
        this.startDayField = value;
      }
    }

    public ReportJobStatus status {
      get {
        return this.statusField;
      }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get {
        return this.statusFieldSpecified;
      }
      set {
        this.statusFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum ReportJobStatus {
    Pending,
    InProgress,
    Completed,
    Failed
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class DefinedReportJob : ReportJob {
    private AdGroupStatus[] adGroupStatusesField;

    private long[] adGroupsField;

    private AdWordsType adWordsTypeField;

    private bool adWordsTypeFieldSpecified;

    private string[] aggregationTypesField;

    private CampaignStatus[] campaignStatusesField;

    private int[] campaignsField;

    private bool includeZeroImpressionField;

    private bool includeZeroImpressionFieldSpecified;

    private KeywordStatus[] keywordStatusesField;

    private KeywordType keywordTypeField;

    private bool keywordTypeFieldSpecified;

    private string[] keywordsField;

    private string[] selectedColumnsField;

    private string selectedReportTypeField;

    [System.Xml.Serialization.XmlElementAttribute("adGroupStatuses")]
    public AdGroupStatus[] adGroupStatuses {
      get {
        return this.adGroupStatusesField;
      }
      set {
        this.adGroupStatusesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("adGroups")]
    public long[] adGroups {
      get {
        return this.adGroupsField;
      }
      set {
        this.adGroupsField = value;
      }
    }

    public AdWordsType adWordsType {
      get {
        return this.adWordsTypeField;
      }
      set {
        this.adWordsTypeField = value;
        this.adWordsTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adWordsTypeSpecified {
      get {
        return this.adWordsTypeFieldSpecified;
      }
      set {
        this.adWordsTypeFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("aggregationTypes")]
    public string[] aggregationTypes {
      get {
        return this.aggregationTypesField;
      }
      set {
        this.aggregationTypesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("campaignStatuses")]
    public CampaignStatus[] campaignStatuses {
      get {
        return this.campaignStatusesField;
      }
      set {
        this.campaignStatusesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("campaigns")]
    public int[] campaigns {
      get {
        return this.campaignsField;
      }
      set {
        this.campaignsField = value;
      }
    }

    public bool includeZeroImpression {
      get {
        return this.includeZeroImpressionField;
      }
      set {
        this.includeZeroImpressionField = value;
        this.includeZeroImpressionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeZeroImpressionSpecified {
      get {
        return this.includeZeroImpressionFieldSpecified;
      }
      set {
        this.includeZeroImpressionFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywordStatuses")]
    public KeywordStatus[] keywordStatuses {
      get {
        return this.keywordStatusesField;
      }
      set {
        this.keywordStatusesField = value;
      }
    }

    public KeywordType keywordType {
      get {
        return this.keywordTypeField;
      }
      set {
        this.keywordTypeField = value;
        this.keywordTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keywordTypeSpecified {
      get {
        return this.keywordTypeFieldSpecified;
      }
      set {
        this.keywordTypeFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywords")]
    public string[] keywords {
      get {
        return this.keywordsField;
      }
      set {
        this.keywordsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("selectedColumns")]
    public string[] selectedColumns {
      get {
        return this.selectedColumnsField;
      }
      set {
        this.selectedColumnsField = value;
      }
    }

    public string selectedReportType {
      get {
        return this.selectedReportTypeField;
      }
      set {
        this.selectedReportTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum AdGroupStatus {
    Enabled,
    Paused,
    Deleted
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum AdWordsType {
    SearchOnly,
    ContentOnly
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum CampaignStatus {
    Active,
    Pending,
    Ended,
    Paused,
    Deleted,
    Suspended
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum KeywordStatus {
    Disapproved,
    Deleted,
    Paused,
    Active,
    InActive
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum KeywordType {
    Broad,
    Phrase,
    Exact
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "TrafficEstimatorServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class TrafficEstimatorService : LegacyAdWordsSoapClient {
    private useragent useragentValueField;

    private password passwordValueField;

    private email emailValueField;

    private clientEmail clientEmailValueField;

    private clientCustomerId clientCustomerIdValueField;

    private developerToken developerTokenValueField;

    private applicationToken applicationTokenValueField;

    private responseTime responseTimeValueField;

    private operations operationsValueField;

    private units unitsValueField;

    private requestId requestIdValueField;

    public TrafficEstimatorService() {
      this.Url = "https://adwords.google.com/api/adwords/v13/TrafficEstimatorService";
    }

    public useragent useragentValue {
      get {
        return this.useragentValueField;
      }
      set {
        this.useragentValueField = value;
      }
    }

    public password passwordValue {
      get {
        return this.passwordValueField;
      }
      set {
        this.passwordValueField = value;
      }
    }

    public email emailValue {
      get {
        return this.emailValueField;
      }
      set {
        this.emailValueField = value;
      }
    }

    public clientEmail clientEmailValue {
      get {
        return this.clientEmailValueField;
      }
      set {
        this.clientEmailValueField = value;
      }
    }

    public clientCustomerId clientCustomerIdValue {
      get {
        return this.clientCustomerIdValueField;
      }
      set {
        this.clientCustomerIdValueField = value;
      }
    }

    public developerToken developerTokenValue {
      get {
        return this.developerTokenValueField;
      }
      set {
        this.developerTokenValueField = value;
      }
    }

    public applicationToken applicationTokenValue {
      get {
        return this.applicationTokenValueField;
      }
      set {
        this.applicationTokenValueField = value;
      }
    }

    public responseTime responseTimeValue {
      get {
        return this.responseTimeValueField;
      }
      set {
        this.responseTimeValueField = value;
      }
    }

    public operations operationsValue {
      get {
        return this.operationsValueField;
      }
      set {
        this.operationsValueField = value;
      }
    }

    public units unitsValue {
      get {
        return this.unitsValueField;
      }
      set {
        this.unitsValueField = value;
      }
    }

    public requestId requestIdValue {
      get {
        return this.requestIdValueField;
      }
      set {
        this.requestIdValueField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("checkKeywordTrafficReturn")]
    public KeywordTraffic[] checkKeywordTraffic([System.Xml.Serialization.XmlElementAttribute("requests")]
KeywordTrafficRequest[] requests) {
      object[] results = this.Invoke("checkKeywordTraffic", new object[] {requests});
      return ((KeywordTraffic[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("estimateAdGroupListReturn")]
    public AdGroupEstimate[] estimateAdGroupList([System.Xml.Serialization.XmlElementAttribute("adGroupRequests")]
AdGroupRequest[] adGroupRequests) {
      object[] results = this.Invoke("estimateAdGroupList", new object[] {adGroupRequests});
      return ((AdGroupEstimate[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("estimateCampaignListReturn")]
    public CampaignEstimate[] estimateCampaignList([System.Xml.Serialization.XmlElementAttribute("campaignRequests")]
CampaignRequest[] campaignRequests) {
      object[] results = this.Invoke("estimateCampaignList", new object[] {campaignRequests});
      return ((CampaignEstimate[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/v13", ResponseNamespace = "https://adwords.google.com/api/adwords/v13", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("estimateKeywordListReturn")]
    public KeywordEstimate[] estimateKeywordList([System.Xml.Serialization.XmlElementAttribute("keywordRequests")]
KeywordRequest[] keywordRequests) {
      object[] results = this.Invoke("estimateKeywordList", new object[] {keywordRequests});
      return ((KeywordEstimate[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class KeywordTrafficRequest {
    private string keywordTextField;

    private KeywordType keywordTypeField;

    private string languageField;

    public string keywordText {
      get {
        return this.keywordTextField;
      }
      set {
        this.keywordTextField = value;
      }
    }

    public KeywordType keywordType {
      get {
        return this.keywordTypeField;
      }
      set {
        this.keywordTypeField = value;
      }
    }

    public string language {
      get {
        return this.languageField;
      }
      set {
        this.languageField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class CampaignEstimate {
    private AdGroupEstimate[] adGroupEstimatesField;

    private int idField;

    private bool idFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("adGroupEstimates")]
    public AdGroupEstimate[] adGroupEstimates {
      get {
        return this.adGroupEstimatesField;
      }
      set {
        this.adGroupEstimatesField = value;
      }
    }

    public int id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class AdGroupEstimate {
    private int idField;

    private bool idFieldSpecified;

    private KeywordEstimate[] keywordEstimatesField;

    public int id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywordEstimates")]
    public KeywordEstimate[] keywordEstimates {
      get {
        return this.keywordEstimatesField;
      }
      set {
        this.keywordEstimatesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class KeywordEstimate {
    private long idField;

    private bool idFieldSpecified;

    private float lowerAvgPositionField;

    private float lowerClicksPerDayField;

    private long lowerCpcField;

    private float upperAvgPositionField;

    private float upperClicksPerDayField;

    private long upperCpcField;

    public long id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }

    public float lowerAvgPosition {
      get {
        return this.lowerAvgPositionField;
      }
      set {
        this.lowerAvgPositionField = value;
      }
    }

    public float lowerClicksPerDay {
      get {
        return this.lowerClicksPerDayField;
      }
      set {
        this.lowerClicksPerDayField = value;
      }
    }

    public long lowerCpc {
      get {
        return this.lowerCpcField;
      }
      set {
        this.lowerCpcField = value;
      }
    }

    public float upperAvgPosition {
      get {
        return this.upperAvgPositionField;
      }
      set {
        this.upperAvgPositionField = value;
      }
    }

    public float upperClicksPerDay {
      get {
        return this.upperClicksPerDayField;
      }
      set {
        this.upperClicksPerDayField = value;
      }
    }

    public long upperCpc {
      get {
        return this.upperCpcField;
      }
      set {
        this.upperCpcField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class RegionTargets {
    private string[] excludedRegionsField;

    private string[] regionsField;

    [System.Xml.Serialization.XmlElementAttribute("excludedRegions")]
    public string[] excludedRegions {
      get {
        return this.excludedRegionsField;
      }
      set {
        this.excludedRegionsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("regions")]
    public string[] regions {
      get {
        return this.regionsField;
      }
      set {
        this.regionsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class Circle {
    private int latitudeMicroDegreesField;

    private int longitudeMicroDegreesField;

    private int radiusMetersField;

    public int latitudeMicroDegrees {
      get {
        return this.latitudeMicroDegreesField;
      }
      set {
        this.latitudeMicroDegreesField = value;
      }
    }

    public int longitudeMicroDegrees {
      get {
        return this.longitudeMicroDegreesField;
      }
      set {
        this.longitudeMicroDegreesField = value;
      }
    }

    public int radiusMeters {
      get {
        return this.radiusMetersField;
      }
      set {
        this.radiusMetersField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class MetroTargets {
    private string[] excludedMetrosField;

    private string[] metrosField;

    [System.Xml.Serialization.XmlElementAttribute("excludedMetros")]
    public string[] excludedMetros {
      get {
        return this.excludedMetrosField;
      }
      set {
        this.excludedMetrosField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("metros")]
    public string[] metros {
      get {
        return this.metrosField;
      }
      set {
        this.metrosField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class CountryTargets {
    private string[] countriesField;

    private string[] excludedCountriesField;

    [System.Xml.Serialization.XmlElementAttribute("countries")]
    public string[] countries {
      get {
        return this.countriesField;
      }
      set {
        this.countriesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("excludedCountries")]
    public string[] excludedCountries {
      get {
        return this.excludedCountriesField;
      }
      set {
        this.excludedCountriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class CityTargets {
    private string[] citiesField;

    private string[] excludedCitiesField;

    [System.Xml.Serialization.XmlElementAttribute("cities")]
    public string[] cities {
      get {
        return this.citiesField;
      }
      set {
        this.citiesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("excludedCities")]
    public string[] excludedCities {
      get {
        return this.excludedCitiesField;
      }
      set {
        this.excludedCitiesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class GeoTarget {
    private CityTargets cityTargetsField;

    private CountryTargets countryTargetsField;

    private MetroTargets metroTargetsField;

    private Circle[] proximityTargetsField;

    private RegionTargets regionTargetsField;

    private bool targetAllField;

    public CityTargets cityTargets {
      get {
        return this.cityTargetsField;
      }
      set {
        this.cityTargetsField = value;
      }
    }

    public CountryTargets countryTargets {
      get {
        return this.countryTargetsField;
      }
      set {
        this.countryTargetsField = value;
      }
    }

    public MetroTargets metroTargets {
      get {
        return this.metroTargetsField;
      }
      set {
        this.metroTargetsField = value;
      }
    }

    [System.Xml.Serialization.XmlArrayItemAttribute("circles", IsNullable = false)]
    public Circle[] proximityTargets {
      get {
        return this.proximityTargetsField;
      }
      set {
        this.proximityTargetsField = value;
      }
    }

    public RegionTargets regionTargets {
      get {
        return this.regionTargetsField;
      }
      set {
        this.regionTargetsField = value;
      }
    }

    public bool targetAll {
      get {
        return this.targetAllField;
      }
      set {
        this.targetAllField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class CampaignRequest {
    private AdGroupRequest[] adGroupRequestsField;

    private GeoTarget geoTargetingField;

    private int idField;

    private bool idFieldSpecified;

    private string[] languageTargetingField;

    private NetworkType[] networkTargetingField;

    [System.Xml.Serialization.XmlElementAttribute("adGroupRequests")]
    public AdGroupRequest[] adGroupRequests {
      get {
        return this.adGroupRequestsField;
      }
      set {
        this.adGroupRequestsField = value;
      }
    }

    public GeoTarget geoTargeting {
      get {
        return this.geoTargetingField;
      }
      set {
        this.geoTargetingField = value;
      }
    }

    public int id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
    [System.Xml.Serialization.XmlArrayItemAttribute("languages")]
    public string[] languageTargeting {
      get {
        return this.languageTargetingField;
      }
      set {
        this.languageTargetingField = value;
      }
    }

    [System.Xml.Serialization.XmlArrayItemAttribute("networkTypes", IsNullable = false)]
    public NetworkType[] networkTargeting {
      get {
        return this.networkTargetingField;
      }
      set {
        this.networkTargetingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class AdGroupRequest {
    private long? idField;

    private bool idFieldSpecified;

    private KeywordRequest[] keywordRequestsField;

    private long maxCpcField;

    private bool maxCpcFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public long? id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywordRequests")]
    public KeywordRequest[] keywordRequests {
      get {
        return this.keywordRequestsField;
      }
      set {
        this.keywordRequestsField = value;
      }
    }

    public long maxCpc {
      get {
        return this.maxCpcField;
      }
      set {
        this.maxCpcField = value;
        this.maxCpcSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maxCpcSpecified {
      get {
        return this.maxCpcFieldSpecified;
      }
      set {
        this.maxCpcFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public partial class KeywordRequest {
    private long idField;

    private bool idFieldSpecified;

    private long maxCpcField;

    private bool maxCpcFieldSpecified;

    private bool negativeField;

    private bool negativeFieldSpecified;

    private string textField;

    private KeywordType typeField;

    private bool typeFieldSpecified;

    public long id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get {
        return this.idFieldSpecified;
      }
      set {
        this.idFieldSpecified = value;
      }
    }

    public long maxCpc {
      get {
        return this.maxCpcField;
      }
      set {
        this.maxCpcField = value;
        this.maxCpcSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maxCpcSpecified {
      get {
        return this.maxCpcFieldSpecified;
      }
      set {
        this.maxCpcFieldSpecified = value;
      }
    }

    public bool negative {
      get {
        return this.negativeField;
      }
      set {
        this.negativeField = value;
        this.negativeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool negativeSpecified {
      get {
        return this.negativeFieldSpecified;
      }
      set {
        this.negativeFieldSpecified = value;
      }
    }

    public string text {
      get {
        return this.textField;
      }
      set {
        this.textField = value;
      }
    }

    public KeywordType type {
      get {
        return this.typeField;
      }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get {
        return this.typeFieldSpecified;
      }
      set {
        this.typeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/v13")]
  public enum KeywordTraffic {
    HasTraffic,
    VeryLowTraffic,
    Unknown
  }
}
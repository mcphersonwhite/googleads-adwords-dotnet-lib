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

namespace Google.Api.Ads.AdWords.v200909 {
  using Google.Api.Ads.AdWords.Headers;
  using Google.Api.Ads.AdWords.Lib;

  using System;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Web.Services;
  using System.Web.Services.Protocols;
  using System.Xml.Serialization;

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "GeoLocationServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class GeoLocationService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public GeoLocationService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/GeoLocationService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public GeoLocation[] get(GeoLocationSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((GeoLocation[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class GeoPoint {
    private int latitudeInMicroDegreesField;

    private bool latitudeInMicroDegreesFieldSpecified;

    private int longitudeInMicroDegreesField;

    private bool longitudeInMicroDegreesFieldSpecified;

    public int latitudeInMicroDegrees {
      get {
        return this.latitudeInMicroDegreesField;
      }
      set {
        this.latitudeInMicroDegreesField = value;
        this.latitudeInMicroDegreesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool latitudeInMicroDegreesSpecified {
      get {
        return this.latitudeInMicroDegreesFieldSpecified;
      }
      set {
        this.latitudeInMicroDegreesFieldSpecified = value;
      }
    }

    public int longitudeInMicroDegrees {
      get {
        return this.longitudeInMicroDegreesField;
      }
      set {
        this.longitudeInMicroDegreesField = value;
        this.longitudeInMicroDegreesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool longitudeInMicroDegreesSpecified {
      get {
        return this.longitudeInMicroDegreesFieldSpecified;
      }
      set {
        this.longitudeInMicroDegreesFieldSpecified = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvalidGeoLocation))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class GeoLocation {
    private GeoPoint geoPointField;

    private Address addressField;

    private byte[] encodedLocationField;

    private string geoLocationTypeField;

    public GeoPoint geoPoint {
      get {
        return this.geoPointField;
      }
      set {
        this.geoPointField = value;
      }
    }

    public Address address {
      get {
        return this.addressField;
      }
      set {
        this.addressField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] encodedLocation {
      get {
        return this.encodedLocationField;
      }
      set {
        this.encodedLocationField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("GeoLocation.Type")]
    public string GeoLocationType {
      get {
        return this.geoLocationTypeField;
      }
      set {
        this.geoLocationTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Address {
    private string streetAddressField;

    private string streetAddress2Field;

    private string cityNameField;

    private string provinceCodeField;

    private string provinceNameField;

    private string postalCodeField;

    private string countryCodeField;

    public string streetAddress {
      get {
        return this.streetAddressField;
      }
      set {
        this.streetAddressField = value;
      }
    }

    public string streetAddress2 {
      get {
        return this.streetAddress2Field;
      }
      set {
        this.streetAddress2Field = value;
      }
    }

    public string cityName {
      get {
        return this.cityNameField;
      }
      set {
        this.cityNameField = value;
      }
    }

    public string provinceCode {
      get {
        return this.provinceCodeField;
      }
      set {
        this.provinceCodeField = value;
      }
    }

    public string provinceName {
      get {
        return this.provinceNameField;
      }
      set {
        this.provinceNameField = value;
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

    public string countryCode {
      get {
        return this.countryCodeField;
      }
      set {
        this.countryCodeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class InvalidGeoLocation : GeoLocation {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class GeoLocationSelector {
    private Address[] addressesField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("addresses")]
    public Address[] addresses {
      get {
        return this.addressesField;
      }
      set {
        this.addressesField = value;
      }
    }

    public string dummy {
      get {
        return this.dummyField;
      }
      set {
        this.dummyField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringLengthError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SizeLimitError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegionCodeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RangeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotaExceededError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotaCheckError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NullError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotWhitelistedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotEmptyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InternalApiError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoLocationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClientTermsError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuthorizationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuthenticationError))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolicyViolationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamPolicyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DatabaseError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatorError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReadOnlyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNotFound))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApiUsageError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionPolicyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsQueryError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCountLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistinctError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetingIdeaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CollectionSizeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PagingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationAccessDenied))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NewEntityCreationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MediaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdCountLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAccessDenied))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingTransitionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionError))]
  public abstract partial class ApiError {
    private string fieldPathField;

    private string triggerField;

    private string apiErrorTypeField;

    public string fieldPath {
      get {
        return this.fieldPathField;
      }
      set {
        this.fieldPathField = value;
      }
    }

    public string trigger {
      get {
        return this.triggerField;
      }
      set {
        this.triggerField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("ApiError.Type")]
    public string ApiErrorType {
      get {
        return this.apiErrorTypeField;
      }
      set {
        this.apiErrorTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class StringLengthError : ApiError {
    private StringLengthErrorReason reasonField;

    private bool reasonFieldSpecified;

    public StringLengthErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringLengthError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum StringLengthErrorReason {
    TOO_SHORT,
    TOO_LONG
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class SizeLimitError : ApiError {
    private SizeLimitErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SizeLimitErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SizeLimitError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum SizeLimitErrorReason {
    REQUEST_SIZE_LIMIT_EXCEEDED,
    RESPONSE_SIZE_LIMIT_EXCEEDED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class RequiredError : ApiError {
    private RequiredErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RequiredErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RequiredError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum RequiredErrorReason {
    REQUIRED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class RegionCodeError : ApiError {
    private RegionCodeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RegionCodeErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RegionCodeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum RegionCodeErrorReason {
    INVALID_REGION_CODE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class RangeError : ApiError {
    private RangeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RangeErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RangeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum RangeErrorReason {
    TOO_LOW,
    TOO_HIGH
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class QuotaExceededError : ApiError {
    private QuotaExceededErrorReason reasonField;

    private bool reasonFieldSpecified;

    public QuotaExceededErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaExceededError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum QuotaExceededErrorReason {
    QUOTA_EXCEEDED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class QuotaCheckError : ApiError {
    private QuotaCheckErrorReason reasonField;

    private bool reasonFieldSpecified;

    public QuotaCheckErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaCheckError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum QuotaCheckErrorReason {
    INVALID_TOKEN_HEADER,
    ACCOUNT_DELINQUENT,
    ACCOUNT_INACCESSIBLE,
    ACCOUNT_INACTIVE,
    INCOMPLETE_SIGNUP,
    INCOMPLETE_SIGNUP_APP_INFO_MISSING,
    INCOMPLETE_SIGNUP_APP_INFO_PENDING,
    INCOMPLETE_SIGNUP_APP_INFO_REJECTED,
    INCOMPLETE_SIGNUP_LATEST_NETAPI_TNC_NOT_AGREED,
    INCOMPLETE_SIGNUP_NO_BILLING_INFO,
    INCOMPLETE_SIGNUP_USER_INFO_MISSING,
    INCOMPLETE_SIGNUP_USER_INFO_PENDING,
    INCOMPLETE_SIGNUP_USER_INFO_REJECTED,
    MONTHLY_BUDGET_REACHED,
    QUOTA_EXCEEDED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NullError : ApiError {
    private NullErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NullErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NullError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum NullErrorReason {
    NULL_CONTENT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NotWhitelistedError : ApiError {
    private NotWhitelistedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NotWhitelistedErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NotWhitelistedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum NotWhitelistedErrorReason {
    CUSTOMER_NOT_WHITELISTED_FOR_API
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NotEmptyError : ApiError {
    private NotEmptyErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NotEmptyErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NotEmptyError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum NotEmptyErrorReason {
    EMPTY_LIST
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class InternalApiError : ApiError {
    private InternalApiErrorReason reasonField;

    private bool reasonFieldSpecified;

    public InternalApiErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "InternalApiError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum InternalApiErrorReason {
    UNEXPECTED_INTERNAL_API_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class GeoLocationError : ApiError {
    private GeoLocationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public GeoLocationErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeoLocationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum GeoLocationErrorReason {
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ClientTermsError : ApiError {
    private ClientTermsErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ClientTermsErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ClientTermsError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum ClientTermsErrorReason {
    INCOMPLETE_SIGNUP_CURRENT_ADWORDS_TNC_NOT_AGREED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AuthorizationError : ApiError {
    private AuthorizationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AuthorizationErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AuthorizationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AuthorizationErrorReason {
    UNABLE_TO_AUTHORIZE,
    NO_ADWORDS_ACCOUNT_FOR_CUSTOMER,
    USER_PERMISSION_DENIED,
    EFFECTIVE_USER_PERMISSION_DENIED,
    USER_HAS_READONLY_PERMISSION,
    NO_CUSTOMER_FOUND
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AuthenticationError : ApiError {
    private AuthenticationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AuthenticationErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AuthenticationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AuthenticationErrorReason {
    AUTHENTICATION_FAILED,
    CLIENT_CUSTOMER_ID_IS_REQUIRED,
    CLIENT_EMAIL_REQUIRED,
    CLIENT_CUSTOMER_ID_INVALID,
    CLIENT_EMAIL_INVALID,
    CLIENT_EMAIL_FAILED_TO_AUTHENTICATE,
    CUSTOMER_NOT_FOUND,
    GOOGLE_ACCOUNT_DELETED,
    GOOGLE_ACCOUNT_COOKIE_INVALID,
    FAILED_TO_AUTHENTICATE_GOOGLE_ACCOUNT,
    GOOGLE_ACCOUNT_USER_AND_ADS_USER_MISMATCH,
    LOGIN_COOKIE_REQUIRED,
    NOT_ADS_USER,
    OAUTH_TOKEN_INVALID,
    OAUTH_TOKEN_EXPIRED,
    OAUTH_TOKEN_DISABLED,
    OAUTH_TOKEN_REVOKED,
    OAUTH_TOKEN_HEADER_INVALID,
    LOGIN_COOKIE_INVALID,
    FAILED_TO_RETRIEVE_LOGIN_COOKIE,
    USER_ID_INVALID
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApiException))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ApplicationException {
    private string messageField;

    private string applicationExceptionTypeField;

    public string message {
      get {
        return this.messageField;
      }
      set {
        this.messageField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("ApplicationException.Type")]
    public string ApplicationExceptionType {
      get {
        return this.applicationExceptionTypeField;
      }
      set {
        this.applicationExceptionTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ApiException : ApplicationException {
    private ApiError[] errorsField;

    [System.Xml.Serialization.XmlElementAttribute("errors")]
    public ApiError[] errors {
      get {
        return this.errorsField;
      }
      set {
        this.errorsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdParamServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdParamService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdParamService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/AdParamService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdParamPage get(AdParamSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((AdParamPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdParam[] mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdParamOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdParam[]) (results[0]));
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamOperation))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignTargetOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionOperation))]
  public abstract partial class Operation {
    private Operator operatorField;

    private bool operatorFieldSpecified;

    private string operationTypeField;

    public Operator @operator {
      get {
        return this.operatorField;
      }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get {
        return this.operatorFieldSpecified;
      }
      set {
        this.operatorFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Operation.Type")]
    public string OperationType {
      get {
        return this.operationTypeField;
      }
      set {
        this.operationTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum Operator {
    ADD,
    REMOVE,
    SET
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdParamOperation : Operation {
    private AdParam operandField;

    public AdParam operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdParam {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    private string insertionTextField;

    private int paramIndexField;

    private bool paramIndexFieldSpecified;

    public long adGroupId {
      get {
        return this.adGroupIdField;
      }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get {
        return this.adGroupIdFieldSpecified;
      }
      set {
        this.adGroupIdFieldSpecified = value;
      }
    }

    public long criterionId {
      get {
        return this.criterionIdField;
      }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get {
        return this.criterionIdFieldSpecified;
      }
      set {
        this.criterionIdFieldSpecified = value;
      }
    }

    public string insertionText {
      get {
        return this.insertionTextField;
      }
      set {
        this.insertionTextField = value;
      }
    }

    public int paramIndex {
      get {
        return this.paramIndexField;
      }
      set {
        this.paramIndexField = value;
        this.paramIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool paramIndexSpecified {
      get {
        return this.paramIndexFieldSpecified;
      }
      set {
        this.paramIndexFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdParamPage {
    private AdParam[] entriesField;

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdParam[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }

    public int totalNumEntries {
      get {
        return this.totalNumEntriesField;
      }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get {
        return this.totalNumEntriesFieldSpecified;
      }
      set {
        this.totalNumEntriesFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Paging {
    private int startIndexField;

    private bool startIndexFieldSpecified;

    private int numberResultsField;

    private bool numberResultsFieldSpecified;

    public int startIndex {
      get {
        return this.startIndexField;
      }
      set {
        this.startIndexField = value;
        this.startIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startIndexSpecified {
      get {
        return this.startIndexFieldSpecified;
      }
      set {
        this.startIndexFieldSpecified = value;
      }
    }

    public int numberResults {
      get {
        return this.numberResultsField;
      }
      set {
        this.numberResultsField = value;
        this.numberResultsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberResultsSpecified {
      get {
        return this.numberResultsFieldSpecified;
      }
      set {
        this.numberResultsFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdParamSelector {
    private long[] adGroupIdsField;

    private long[] criteriaIdField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("adGroupIds")]
    public long[] adGroupIds {
      get {
        return this.adGroupIdsField;
      }
      set {
        this.adGroupIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("criteriaId")]
    public long[] criteriaId {
      get {
        return this.criteriaIdField;
      }
      set {
        this.criteriaIdField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PolicyViolationError.Part", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class PolicyViolationErrorPart {
    private int indexField;

    private bool indexFieldSpecified;

    private int lengthField;

    private bool lengthFieldSpecified;

    public int index {
      get {
        return this.indexField;
      }
      set {
        this.indexField = value;
        this.indexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool indexSpecified {
      get {
        return this.indexFieldSpecified;
      }
      set {
        this.indexFieldSpecified = value;
      }
    }

    public int length {
      get {
        return this.lengthField;
      }
      set {
        this.lengthField = value;
        this.lengthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool lengthSpecified {
      get {
        return this.lengthFieldSpecified;
      }
      set {
        this.lengthFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class PolicyViolationKey {
    private string policyNameField;

    private string violatingTextField;

    public string policyName {
      get {
        return this.policyNameField;
      }
      set {
        this.policyNameField = value;
      }
    }

    public string violatingText {
      get {
        return this.violatingTextField;
      }
      set {
        this.violatingTextField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamPolicyError))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionPolicyError))]
  public partial class PolicyViolationError : ApiError {
    private PolicyViolationKey keyField;

    private string externalPolicyNameField;

    private string externalPolicyUrlField;

    private string externalPolicyDescriptionField;

    private bool isExemptableField;

    private bool isExemptableFieldSpecified;

    private PolicyViolationErrorPart[] violatingPartsField;

    public PolicyViolationKey key {
      get {
        return this.keyField;
      }
      set {
        this.keyField = value;
      }
    }

    public string externalPolicyName {
      get {
        return this.externalPolicyNameField;
      }
      set {
        this.externalPolicyNameField = value;
      }
    }

    public string externalPolicyUrl {
      get {
        return this.externalPolicyUrlField;
      }
      set {
        this.externalPolicyUrlField = value;
      }
    }

    public string externalPolicyDescription {
      get {
        return this.externalPolicyDescriptionField;
      }
      set {
        this.externalPolicyDescriptionField = value;
      }
    }

    public bool isExemptable {
      get {
        return this.isExemptableField;
      }
      set {
        this.isExemptableField = value;
        this.isExemptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isExemptableSpecified {
      get {
        return this.isExemptableFieldSpecified;
      }
      set {
        this.isExemptableFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("violatingParts")]
    public PolicyViolationErrorPart[] violatingParts {
      get {
        return this.violatingPartsField;
      }
      set {
        this.violatingPartsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdParamPolicyError : PolicyViolationError {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class DatabaseError : ApiError {
    private DatabaseErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DatabaseErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DatabaseError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum DatabaseErrorReason {
    CONCURRENT_MODIFICATION,
    PERMISSION_DENIED,
    CAMPAIGN_PRODUCT_NOT_SUPPORTED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class OperatorError : ApiError {
    private OperatorErrorReason reasonField;

    private bool reasonFieldSpecified;

    public OperatorErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OperatorError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum OperatorErrorReason {
    OPERATOR_NOT_SUPPORTED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdParamError : ApiError {
    private AdParamErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdParamErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdParamError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdParamErrorReason {
    AD_PARAM_CANNOT_BE_SPECIFIED_MULTIPLE_TIMES,
    AD_PARAM_DOES_NOT_EXIST,
    CRITERION_SPECIFIED_MUST_BE_KEYWORD,
    INVALID_ADGROUP_CRITERION_SPECIFIED,
    INVALID_INSERTION_TEXT_FORMAT,
    MUST_SPECIFY_ADGROUP_ID
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "InfoServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/info/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class InfoService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public InfoService() {
      this.Url = "https://adwords.google.com/api/adwords/info/v200909/InfoService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/info/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/info/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public ApiUsageInfo get(InfoSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((ApiUsageInfo) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v200909")]
  public partial class ApiUsageRecord {
    private string clientEmailField;

    private long costField;

    private bool costFieldSpecified;

    public string clientEmail {
      get {
        return this.clientEmailField;
      }
      set {
        this.clientEmailField = value;
      }
    }

    public long cost {
      get {
        return this.costField;
      }
      set {
        this.costField = value;
        this.costSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool costSpecified {
      get {
        return this.costFieldSpecified;
      }
      set {
        this.costFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v200909")]
  public partial class ApiUsageInfo {
    private ApiUsageRecord[] apiUsageRecordsField;

    private long costField;

    private bool costFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("apiUsageRecords")]
    public ApiUsageRecord[] apiUsageRecords {
      get {
        return this.apiUsageRecordsField;
      }
      set {
        this.apiUsageRecordsField = value;
      }
    }

    public long cost {
      get {
        return this.costField;
      }
      set {
        this.costField = value;
        this.costSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool costSpecified {
      get {
        return this.costFieldSpecified;
      }
      set {
        this.costFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class DateRange {
    private string minField;

    private string maxField;

    public string min {
      get {
        return this.minField;
      }
      set {
        this.minField = value;
      }
    }

    public string max {
      get {
        return this.maxField;
      }
      set {
        this.maxField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v200909")]
  public partial class InfoSelector {
    private string serviceNameField;

    private string methodNameField;

    private Operator operatorField;

    private bool operatorFieldSpecified;

    private DateRange dateRangeField;

    private string[] clientEmailsField;

    private ApiUsageType apiUsageTypeField;

    private bool apiUsageTypeFieldSpecified;

    public string serviceName {
      get {
        return this.serviceNameField;
      }
      set {
        this.serviceNameField = value;
      }
    }

    public string methodName {
      get {
        return this.methodNameField;
      }
      set {
        this.methodNameField = value;
      }
    }

    public Operator @operator {
      get {
        return this.operatorField;
      }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get {
        return this.operatorFieldSpecified;
      }
      set {
        this.operatorFieldSpecified = value;
      }
    }

    public DateRange dateRange {
      get {
        return this.dateRangeField;
      }
      set {
        this.dateRangeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("clientEmails")]
    public string[] clientEmails {
      get {
        return this.clientEmailsField;
      }
      set {
        this.clientEmailsField = value;
      }
    }

    public ApiUsageType apiUsageType {
      get {
        return this.apiUsageTypeField;
      }
      set {
        this.apiUsageTypeField = value;
        this.apiUsageTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool apiUsageTypeSpecified {
      get {
        return this.apiUsageTypeFieldSpecified;
      }
      set {
        this.apiUsageTypeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v200909")]
  public enum ApiUsageType {
    FREE_USAGE_API_UNITS_PER_MONTH,
    TOTAL_USAGE_API_UNITS_PER_MONTH,
    OPERATION_COUNT,
    UNIT_COUNT,
    UNIT_COUNT_FOR_CLIENTS,
    METHOD_COST
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ReadOnlyError : ApiError {
    private ReadOnlyErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ReadOnlyErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReadOnlyError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum ReadOnlyErrorReason {
    READ_ONLY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class EntityNotFound : ApiError {
    private EntityNotFoundReason reasonField;

    private bool reasonFieldSpecified;

    public EntityNotFoundReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityNotFound.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum EntityNotFoundReason {
    INVALID_ID
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v200909")]
  public partial class ApiUsageError : ApiError {
    private ApiUsageErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ApiUsageErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ApiUsageError.Reason", Namespace = "https://adwords.google.com/api/adwords/info/v200909")]
  public enum ApiUsageErrorReason {
    INVALID_DATE_RANGE,
    SERVICE_NAME_NOT_SPECIFIED,
    METHOD_NAME_NOT_SPECIFIED,
    OPERATOR_NOT_SPECIFIED,
    INVALID_CLIENT_EMAIL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "TargetingIdeaServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Criterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Target))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class TargetingIdeaService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public TargetingIdeaService() {
      this.Url = "https://adwords.google.com/api/adwords/o/v200909/TargetingIdeaService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public TargetingIdeaPage get(TargetingIdeaSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((TargetingIdeaPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public TargetingIdeaPage getBulkKeywordIdeas(TargetingIdeaSelector selector) {
      object[] results = this.Invoke("getBulkKeywordIdeas", new object[] {selector});
      return ((TargetingIdeaPage) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class Range {
    private ComparableValue minField;

    private ComparableValue maxField;

    public ComparableValue min {
      get {
        return this.minField;
      }
      set {
        this.minField = value;
      }
    }

    public ComparableValue max {
      get {
        return this.maxField;
      }
      set {
        this.maxField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumberValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Money))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class ComparableValue {
    private string comparableValueTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ComparableValue.Type")]
    public string ComparableValueType {
      get {
        return this.comparableValueTypeField;
      }
      set {
        this.comparableValueTypeField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class NumberValue : ComparableValue {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class LongValue : NumberValue {
    private long numberField;

    private bool numberFieldSpecified;

    public long number {
      get {
        return this.numberField;
      }
      set {
        this.numberField = value;
        this.numberSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberSpecified {
      get {
        return this.numberFieldSpecified;
      }
      set {
        this.numberFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class DoubleValue : NumberValue {
    private double numberField;

    private bool numberFieldSpecified;

    public double number {
      get {
        return this.numberField;
      }
      set {
        this.numberField = value;
        this.numberSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberSpecified {
      get {
        return this.numberFieldSpecified;
      }
      set {
        this.numberFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Money : ComparableValue {
    private long microAmountField;

    private bool microAmountFieldSpecified;

    public long microAmount {
      get {
        return this.microAmountField;
      }
      set {
        this.microAmountField = value;
        this.microAmountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool microAmountSpecified {
      get {
        return this.microAmountFieldSpecified;
      }
      set {
        this.microAmountFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class WebpageDescriptor {
    private string urlField;

    private string titleField;

    public string url {
      get {
        return this.urlField;
      }
      set {
        this.urlField = value;
      }
    }

    public string title {
      get {
        return this.titleField;
      }
      set {
        this.titleField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class MonthlySearchVolume {
    private int yearField;

    private bool yearFieldSpecified;

    private int monthField;

    private bool monthFieldSpecified;

    private long countField;

    private bool countFieldSpecified;

    public int year {
      get {
        return this.yearField;
      }
      set {
        this.yearField = value;
        this.yearSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool yearSpecified {
      get {
        return this.yearFieldSpecified;
      }
      set {
        this.yearFieldSpecified = value;
      }
    }

    public int month {
      get {
        return this.monthField;
      }
      set {
        this.monthField = value;
        this.monthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool monthSpecified {
      get {
        return this.monthFieldSpecified;
      }
      set {
        this.monthFieldSpecified = value;
      }
    }

    public long count {
      get {
        return this.countField;
      }
      set {
        this.countField = value;
        this.countSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool countSpecified {
      get {
        return this.countFieldSpecified;
      }
      set {
        this.countFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class InStreamAdInfo {
    private int maxAdDurationField;

    private bool maxAdDurationFieldSpecified;

    private int minAdDurationField;

    private bool minAdDurationFieldSpecified;

    private int medianAdDurationField;

    private bool medianAdDurationFieldSpecified;

    private double preRollPercentField;

    private bool preRollPercentFieldSpecified;

    private double midRollPercentField;

    private bool midRollPercentFieldSpecified;

    private double postRollPercentField;

    private bool postRollPercentFieldSpecified;

    public int maxAdDuration {
      get {
        return this.maxAdDurationField;
      }
      set {
        this.maxAdDurationField = value;
        this.maxAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maxAdDurationSpecified {
      get {
        return this.maxAdDurationFieldSpecified;
      }
      set {
        this.maxAdDurationFieldSpecified = value;
      }
    }

    public int minAdDuration {
      get {
        return this.minAdDurationField;
      }
      set {
        this.minAdDurationField = value;
        this.minAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool minAdDurationSpecified {
      get {
        return this.minAdDurationFieldSpecified;
      }
      set {
        this.minAdDurationFieldSpecified = value;
      }
    }

    public int medianAdDuration {
      get {
        return this.medianAdDurationField;
      }
      set {
        this.medianAdDurationField = value;
        this.medianAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool medianAdDurationSpecified {
      get {
        return this.medianAdDurationFieldSpecified;
      }
      set {
        this.medianAdDurationFieldSpecified = value;
      }
    }

    public double preRollPercent {
      get {
        return this.preRollPercentField;
      }
      set {
        this.preRollPercentField = value;
        this.preRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool preRollPercentSpecified {
      get {
        return this.preRollPercentFieldSpecified;
      }
      set {
        this.preRollPercentFieldSpecified = value;
      }
    }

    public double midRollPercent {
      get {
        return this.midRollPercentField;
      }
      set {
        this.midRollPercentField = value;
        this.midRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool midRollPercentSpecified {
      get {
        return this.midRollPercentFieldSpecified;
      }
      set {
        this.midRollPercentFieldSpecified = value;
      }
    }

    public double postRollPercent {
      get {
        return this.postRollPercentField;
      }
      set {
        this.postRollPercentField = value;
        this.postRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool postRollPercentSpecified {
      get {
        return this.postRollPercentFieldSpecified;
      }
      set {
        this.postRollPercentFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class AdFormatSpec {
    private SiteConstantsAdFormat formatField;

    private bool formatFieldSpecified;

    public SiteConstantsAdFormat format {
      get {
        return this.formatField;
      }
      set {
        this.formatField = value;
        this.formatSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool formatSpecified {
      get {
        return this.formatFieldSpecified;
      }
      set {
        this.formatFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.AdFormat", Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum SiteConstantsAdFormat {
    TEXT,
    IMAGE,
    VIDEO,
    INSTREAM
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongRangeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MoneyAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebpageDescriptorAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MonthlySearchVolumeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerSetAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InStreamAdInfoAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdeaTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdFormatSpecListAttribute))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public abstract partial class Attribute {
    private string attributeTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Attribute.Type")]
    public string AttributeType {
      get {
        return this.attributeTypeField;
      }
      set {
        this.attributeTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class PlacementAttribute : Attribute {
    private Placement valueField;

    public Placement value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Placement : Criterion {
    private string urlField;

    public string url {
      get {
        return this.urlField;
      }
      set {
        this.urlField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Placement))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Keyword))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContentLabel))]
  public partial class Criterion {
    private long idField;

    private bool idFieldSpecified;

    private string criterionTypeField;

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

    [System.Xml.Serialization.XmlElementAttribute("Criterion.Type")]
    public string CriterionType {
      get {
        return this.criterionTypeField;
      }
      set {
        this.criterionTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Keyword : Criterion {
    private string textField;

    private KeywordMatchType matchTypeField;

    private bool matchTypeFieldSpecified;

    public string text {
      get {
        return this.textField;
      }
      set {
        this.textField = value;
      }
    }

    public KeywordMatchType matchType {
      get {
        return this.matchTypeField;
      }
      set {
        this.matchTypeField = value;
        this.matchTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool matchTypeSpecified {
      get {
        return this.matchTypeFieldSpecified;
      }
      set {
        this.matchTypeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum KeywordMatchType {
    EXACT,
    PHRASE,
    BROAD
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class KeywordAttribute : Attribute {
    private Keyword valueField;

    public Keyword value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class LongRangeAttribute : Attribute {
    private Range valueField;

    public Range value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class MoneyAttribute : Attribute {
    private Money valueField;

    public Money value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class WebpageDescriptorAttribute : Attribute {
    private WebpageDescriptor valueField;

    public WebpageDescriptor value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class StringAttribute : Attribute {
    private string valueField;

    public string value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class PlacementTypeAttribute : Attribute {
    private SiteConstantsPlacementType valueField;

    private bool valueFieldSpecified;

    public SiteConstantsPlacementType value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.PlacementType", Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum SiteConstantsPlacementType {
    SITE,
    VIDEO,
    FEED,
    GAME,
    MOBILE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class MonthlySearchVolumeAttribute : Attribute {
    private MonthlySearchVolume[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public MonthlySearchVolume[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class LongAttribute : Attribute {
    private long valueField;

    private bool valueFieldSpecified;

    public long value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class IntegerSetAttribute : Attribute {
    private int[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public int[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class IntegerAttribute : Attribute {
    private int valueField;

    private bool valueFieldSpecified;

    public int value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class InStreamAdInfoAttribute : Attribute {
    private InStreamAdInfo valueField;

    public InStreamAdInfo value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class IdeaTypeAttribute : Attribute {
    private IdeaType valueField;

    private bool valueFieldSpecified;

    public IdeaType value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum IdeaType {
    KEYWORD,
    PLACEMENT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class DoubleAttribute : Attribute {
    private double valueField;

    private bool valueFieldSpecified;

    public double value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class BooleanAttribute : Attribute {
    private bool valueField;

    private bool valueFieldSpecified;

    public bool value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class AdFormatSpecListAttribute : Attribute {
    private AdFormatSpec[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdFormatSpec[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class Type_AttributeMapEntry {
    private AttributeType keyField;

    private bool keyFieldSpecified;

    private Attribute valueField;

    public AttributeType key {
      get {
        return this.keyField;
      }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get {
        return this.keyFieldSpecified;
      }
      set {
        this.keyFieldSpecified = value;
      }
    }

    public Attribute value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum AttributeType {
    AD_SHARE,
    APPROX_CONTENT_IMPRESSIONS_PER_DAY,
    AVERAGE_TARGETED_MONTHLY_SEARCHES,
    COMPETITION,
    EXTRACTED_FROM_WEBPAGE,
    FORMATS,
    GLOBAL_MONTHLY_SEARCHES,
    IDEA_TYPE,
    IN_STREAM_AD_INFO,
    KEYWORD,
    KEYWORD_CATEGORY,
    NGRAM_GROUP,
    PLACEMENT,
    PLACEMENT_NAME,
    SAMPLE_URL,
    SEARCH_SHARE,
    PLACEMENT_CATEGORY,
    PLACEMENT_TYPE,
    PUBLISHER_DESCRIPTION,
    TARGETED_MONTHLY_SEARCHES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class TargetingIdea {
    private Type_AttributeMapEntry[] dataField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("data")]
    public Type_AttributeMapEntry[] data {
      get {
        return this.dataField;
      }
      set {
        this.dataField = value;
      }
    }

    public string dummy {
      get {
        return this.dummyField;
      }
      set {
        this.dummyField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class TargetingIdeaPage {
    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    private TargetingIdea[] entriesField;

    public int totalNumEntries {
      get {
        return this.totalNumEntriesField;
      }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get {
        return this.totalNumEntriesFieldSpecified;
      }
      set {
        this.totalNumEntriesFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public TargetingIdea[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProximityTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProvinceTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MetroTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountryTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CityTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DemographicTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenderTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AgeTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlatformTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdScheduleTarget))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class Target {
    private string targetTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Target.Type")]
    public string TargetType {
      get {
        return this.targetTypeField;
      }
      set {
        this.targetTypeField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProximityTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProvinceTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MetroTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountryTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CityTarget))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class GeoTarget : Target {
    private bool excludedField;

    private bool excludedFieldSpecified;

    public bool excluded {
      get {
        return this.excludedField;
      }
      set {
        this.excludedField = value;
        this.excludedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool excludedSpecified {
      get {
        return this.excludedFieldSpecified;
      }
      set {
        this.excludedFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ProximityTarget : GeoTarget {
    private GeoPoint geoPointField;

    private ProximityTargetDistanceUnits radiusDistanceUnitsField;

    private bool radiusDistanceUnitsFieldSpecified;

    private double radiusInUnitsField;

    private bool radiusInUnitsFieldSpecified;

    private Address addressField;

    private bool allowServiceOfAddressField;

    private bool allowServiceOfAddressFieldSpecified;

    public GeoPoint geoPoint {
      get {
        return this.geoPointField;
      }
      set {
        this.geoPointField = value;
      }
    }

    public ProximityTargetDistanceUnits radiusDistanceUnits {
      get {
        return this.radiusDistanceUnitsField;
      }
      set {
        this.radiusDistanceUnitsField = value;
        this.radiusDistanceUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusDistanceUnitsSpecified {
      get {
        return this.radiusDistanceUnitsFieldSpecified;
      }
      set {
        this.radiusDistanceUnitsFieldSpecified = value;
      }
    }

    public double radiusInUnits {
      get {
        return this.radiusInUnitsField;
      }
      set {
        this.radiusInUnitsField = value;
        this.radiusInUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusInUnitsSpecified {
      get {
        return this.radiusInUnitsFieldSpecified;
      }
      set {
        this.radiusInUnitsFieldSpecified = value;
      }
    }

    public Address address {
      get {
        return this.addressField;
      }
      set {
        this.addressField = value;
      }
    }

    public bool allowServiceOfAddress {
      get {
        return this.allowServiceOfAddressField;
      }
      set {
        this.allowServiceOfAddressField = value;
        this.allowServiceOfAddressSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool allowServiceOfAddressSpecified {
      get {
        return this.allowServiceOfAddressFieldSpecified;
      }
      set {
        this.allowServiceOfAddressFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProximityTarget.DistanceUnits", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum ProximityTargetDistanceUnits {
    KILOMETERS,
    MILES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ProvinceTarget : GeoTarget {
    private string provinceCodeField;

    public string provinceCode {
      get {
        return this.provinceCodeField;
      }
      set {
        this.provinceCodeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class PolygonTarget : GeoTarget {
    private GeoPoint[] verticesField;

    [System.Xml.Serialization.XmlElementAttribute("vertices")]
    public GeoPoint[] vertices {
      get {
        return this.verticesField;
      }
      set {
        this.verticesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class MetroTarget : GeoTarget {
    private string metroCodeField;

    public string metroCode {
      get {
        return this.metroCodeField;
      }
      set {
        this.metroCodeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CountryTarget : GeoTarget {
    private string countryCodeField;

    public string countryCode {
      get {
        return this.countryCodeField;
      }
      set {
        this.countryCodeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CityTarget : GeoTarget {
    private string cityNameField;

    private string provinceCodeField;

    private string countryCodeField;

    public string cityName {
      get {
        return this.cityNameField;
      }
      set {
        this.cityNameField = value;
      }
    }

    public string provinceCode {
      get {
        return this.provinceCodeField;
      }
      set {
        this.provinceCodeField = value;
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
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenderTarget))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AgeTarget))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class DemographicTarget : Target {
    private int bidModifierField;

    private bool bidModifierFieldSpecified;

    public int bidModifier {
      get {
        return this.bidModifierField;
      }
      set {
        this.bidModifierField = value;
        this.bidModifierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidModifierSpecified {
      get {
        return this.bidModifierFieldSpecified;
      }
      set {
        this.bidModifierFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class GenderTarget : DemographicTarget {
    private GenderTargetGender genderField;

    private bool genderFieldSpecified;

    public GenderTargetGender gender {
      get {
        return this.genderField;
      }
      set {
        this.genderField = value;
        this.genderSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool genderSpecified {
      get {
        return this.genderFieldSpecified;
      }
      set {
        this.genderFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GenderTarget.Gender", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum GenderTargetGender {
    MALE,
    FEMALE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AgeTarget : DemographicTarget {
    private AgeTargetAge ageField;

    private bool ageFieldSpecified;

    public AgeTargetAge age {
      get {
        return this.ageField;
      }
      set {
        this.ageField = value;
        this.ageSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ageSpecified {
      get {
        return this.ageFieldSpecified;
      }
      set {
        this.ageFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AgeTarget.Age", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AgeTargetAge {
    AGE_0_17,
    AGE_18_24,
    AGE_25_34,
    AGE_35_44,
    AGE_45_54,
    AGE_55_64,
    AGE_65_PLUS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class PlatformTarget : Target {
    private PlatformType platformTypeField;

    private bool platformTypeFieldSpecified;

    public PlatformType platformType {
      get {
        return this.platformTypeField;
      }
      set {
        this.platformTypeField = value;
        this.platformTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool platformTypeSpecified {
      get {
        return this.platformTypeFieldSpecified;
      }
      set {
        this.platformTypeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum PlatformType {
    DESKTOP,
    HIGH_END_MOBILE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NetworkTarget : Target {
    private NetworkCoverageType networkCoverageTypeField;

    private bool networkCoverageTypeFieldSpecified;

    public NetworkCoverageType networkCoverageType {
      get {
        return this.networkCoverageTypeField;
      }
      set {
        this.networkCoverageTypeField = value;
        this.networkCoverageTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool networkCoverageTypeSpecified {
      get {
        return this.networkCoverageTypeFieldSpecified;
      }
      set {
        this.networkCoverageTypeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum NetworkCoverageType {
    GOOGLE_SEARCH,
    SEARCH_NETWORK,
    CONTENT_NETWORK,
    CONTENT_CONTEXTUAL,
    CPA_REFERRAL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class LanguageTarget : Target {
    private string languageCodeField;

    public string languageCode {
      get {
        return this.languageCodeField;
      }
      set {
        this.languageCodeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdScheduleTarget : Target {
    private DayOfWeek dayOfWeekField;

    private bool dayOfWeekFieldSpecified;

    private int startHourField;

    private bool startHourFieldSpecified;

    private MinuteOfHour startMinuteField;

    private bool startMinuteFieldSpecified;

    private int endHourField;

    private bool endHourFieldSpecified;

    private MinuteOfHour endMinuteField;

    private bool endMinuteFieldSpecified;

    private double bidMultiplierField;

    private bool bidMultiplierFieldSpecified;

    public DayOfWeek dayOfWeek {
      get {
        return this.dayOfWeekField;
      }
      set {
        this.dayOfWeekField = value;
        this.dayOfWeekSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool dayOfWeekSpecified {
      get {
        return this.dayOfWeekFieldSpecified;
      }
      set {
        this.dayOfWeekFieldSpecified = value;
      }
    }

    public int startHour {
      get {
        return this.startHourField;
      }
      set {
        this.startHourField = value;
        this.startHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startHourSpecified {
      get {
        return this.startHourFieldSpecified;
      }
      set {
        this.startHourFieldSpecified = value;
      }
    }

    public MinuteOfHour startMinute {
      get {
        return this.startMinuteField;
      }
      set {
        this.startMinuteField = value;
        this.startMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startMinuteSpecified {
      get {
        return this.startMinuteFieldSpecified;
      }
      set {
        this.startMinuteFieldSpecified = value;
      }
    }

    public int endHour {
      get {
        return this.endHourField;
      }
      set {
        this.endHourField = value;
        this.endHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endHourSpecified {
      get {
        return this.endHourFieldSpecified;
      }
      set {
        this.endHourFieldSpecified = value;
      }
    }

    public MinuteOfHour endMinute {
      get {
        return this.endMinuteField;
      }
      set {
        this.endMinuteField = value;
        this.endMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endMinuteSpecified {
      get {
        return this.endMinuteFieldSpecified;
      }
      set {
        this.endMinuteFieldSpecified = value;
      }
    }

    public double bidMultiplier {
      get {
        return this.bidMultiplierField;
      }
      set {
        this.bidMultiplierField = value;
        this.bidMultiplierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidMultiplierSpecified {
      get {
        return this.bidMultiplierFieldSpecified;
      }
      set {
        this.bidMultiplierFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum DayOfWeek {
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MinuteOfHour {
    ZERO,
    FIFTEEN,
    THIRTY,
    FORTY_FIVE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class LongComparisonOperation {
    private long minimumField;

    private bool minimumFieldSpecified;

    private long maximumField;

    private bool maximumFieldSpecified;

    private long[] excludesField;

    public long minimum {
      get {
        return this.minimumField;
      }
      set {
        this.minimumField = value;
        this.minimumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool minimumSpecified {
      get {
        return this.minimumFieldSpecified;
      }
      set {
        this.minimumFieldSpecified = value;
      }
    }

    public long maximum {
      get {
        return this.maximumField;
      }
      set {
        this.maximumField = value;
        this.maximumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maximumSpecified {
      get {
        return this.maximumFieldSpecified;
      }
      set {
        this.maximumFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("excludes")]
    public long[] excludes {
      get {
        return this.excludesField;
      }
      set {
        this.excludesField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedToKeywordSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExcludedKeywordSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageTargetSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountryTargetSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalMonthlySearchesSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AverageTargetedMonthlySearchesSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeedAdGroupIdSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedToUrlSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementTypeSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NgramGroupsSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordMatchTypeSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordCategoryIdSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IncludeAdultContentSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompetitionSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdTypeSearchParameter))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public abstract partial class SearchParameter {
    private string searchParameterTypeField;

    [System.Xml.Serialization.XmlElementAttribute("SearchParameter.Type")]
    public string SearchParameterType {
      get {
        return this.searchParameterTypeField;
      }
      set {
        this.searchParameterTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class RelatedToKeywordSearchParameter : SearchParameter {
    private Keyword[] keywordsField;

    [System.Xml.Serialization.XmlElementAttribute("keywords")]
    public Keyword[] keywords {
      get {
        return this.keywordsField;
      }
      set {
        this.keywordsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class ExcludedKeywordSearchParameter : SearchParameter {
    private Keyword[] keywordsField;

    [System.Xml.Serialization.XmlElementAttribute("keywords")]
    public Keyword[] keywords {
      get {
        return this.keywordsField;
      }
      set {
        this.keywordsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class LanguageTargetSearchParameter : SearchParameter {
    private LanguageTarget[] languageTargetsField;

    [System.Xml.Serialization.XmlElementAttribute("languageTargets")]
    public LanguageTarget[] languageTargets {
      get {
        return this.languageTargetsField;
      }
      set {
        this.languageTargetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class CountryTargetSearchParameter : SearchParameter {
    private CountryTarget[] countryTargetsField;

    [System.Xml.Serialization.XmlElementAttribute("countryTargets")]
    public CountryTarget[] countryTargets {
      get {
        return this.countryTargetsField;
      }
      set {
        this.countryTargetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class GlobalMonthlySearchesSearchParameter : SearchParameter {
    private LongComparisonOperation operationField;

    public LongComparisonOperation operation {
      get {
        return this.operationField;
      }
      set {
        this.operationField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class AverageTargetedMonthlySearchesSearchParameter : SearchParameter {
    private LongComparisonOperation operationField;

    public LongComparisonOperation operation {
      get {
        return this.operationField;
      }
      set {
        this.operationField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class SeedAdGroupIdSearchParameter : SearchParameter {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    public long adGroupId {
      get {
        return this.adGroupIdField;
      }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get {
        return this.adGroupIdFieldSpecified;
      }
      set {
        this.adGroupIdFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class RelatedToUrlSearchParameter : SearchParameter {
    private string[] urlsField;

    private bool includeSubUrlsField;

    private bool includeSubUrlsFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("urls")]
    public string[] urls {
      get {
        return this.urlsField;
      }
      set {
        this.urlsField = value;
      }
    }

    public bool includeSubUrls {
      get {
        return this.includeSubUrlsField;
      }
      set {
        this.includeSubUrlsField = value;
        this.includeSubUrlsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeSubUrlsSpecified {
      get {
        return this.includeSubUrlsFieldSpecified;
      }
      set {
        this.includeSubUrlsFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class PlacementTypeSearchParameter : SearchParameter {
    private SiteConstantsPlacementType[] placementTypesField;

    [System.Xml.Serialization.XmlElementAttribute("placementTypes")]
    public SiteConstantsPlacementType[] placementTypes {
      get {
        return this.placementTypesField;
      }
      set {
        this.placementTypesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class NgramGroupsSearchParameter : SearchParameter {
    private string[] ngramGroupsField;

    [System.Xml.Serialization.XmlElementAttribute("ngramGroups")]
    public string[] ngramGroups {
      get {
        return this.ngramGroupsField;
      }
      set {
        this.ngramGroupsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class MobileSearchParameter : SearchParameter {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class KeywordMatchTypeSearchParameter : SearchParameter {
    private KeywordMatchType[] keywordMatchTypesField;

    [System.Xml.Serialization.XmlElementAttribute("keywordMatchTypes")]
    public KeywordMatchType[] keywordMatchTypes {
      get {
        return this.keywordMatchTypesField;
      }
      set {
        this.keywordMatchTypesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class KeywordCategoryIdSearchParameter : SearchParameter {
    private int categoryIdField;

    private bool categoryIdFieldSpecified;

    public int categoryId {
      get {
        return this.categoryIdField;
      }
      set {
        this.categoryIdField = value;
        this.categoryIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categoryIdSpecified {
      get {
        return this.categoryIdFieldSpecified;
      }
      set {
        this.categoryIdFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class IncludeAdultContentSearchParameter : SearchParameter {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class CompetitionSearchParameter : SearchParameter {
    private CompetitionSearchParameterLevel[] levelsField;

    [System.Xml.Serialization.XmlElementAttribute("levels")]
    public CompetitionSearchParameterLevel[] levels {
      get {
        return this.levelsField;
      }
      set {
        this.levelsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CompetitionSearchParameter.Level", Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum CompetitionSearchParameterLevel {
    LOW,
    MEDIUM,
    HIGH
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class AdTypeSearchParameter : SearchParameter {
    private SiteConstantsAdType[] adTypesField;

    [System.Xml.Serialization.XmlElementAttribute("adTypes")]
    public SiteConstantsAdType[] adTypes {
      get {
        return this.adTypesField;
      }
      set {
        this.adTypesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.AdType", Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum SiteConstantsAdType {
    TEXT,
    DISPLAY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class TargetingIdeaSelector {
    private SearchParameter[] searchParametersField;

    private IdeaType ideaTypeField;

    private bool ideaTypeFieldSpecified;

    private RequestType requestTypeField;

    private bool requestTypeFieldSpecified;

    private AttributeType[] requestedAttributeTypesField;

    private Paging pagingField;

    private string localeCodeField;

    private string currencyCodeField;

    [System.Xml.Serialization.XmlElementAttribute("searchParameters")]
    public SearchParameter[] searchParameters {
      get {
        return this.searchParametersField;
      }
      set {
        this.searchParametersField = value;
      }
    }

    public IdeaType ideaType {
      get {
        return this.ideaTypeField;
      }
      set {
        this.ideaTypeField = value;
        this.ideaTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ideaTypeSpecified {
      get {
        return this.ideaTypeFieldSpecified;
      }
      set {
        this.ideaTypeFieldSpecified = value;
      }
    }

    public RequestType requestType {
      get {
        return this.requestTypeField;
      }
      set {
        this.requestTypeField = value;
        this.requestTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool requestTypeSpecified {
      get {
        return this.requestTypeFieldSpecified;
      }
      set {
        this.requestTypeFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("requestedAttributeTypes")]
    public AttributeType[] requestedAttributeTypes {
      get {
        return this.requestedAttributeTypesField;
      }
      set {
        this.requestedAttributeTypesField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }

    public string localeCode {
      get {
        return this.localeCodeField;
      }
      set {
        this.localeCodeField = value;
      }
    }

    public string currencyCode {
      get {
        return this.currencyCodeField;
      }
      set {
        this.currencyCodeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum RequestType {
    IDEAS,
    STATS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CriterionPolicyError : PolicyViolationError {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class TargetError : ApiError {
    private TargetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TargetErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TargetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum TargetErrorReason {
    AD_SCHEDULE_ADVANCED_INCOMPATIBLE_WITH_CONVERSION_OPTIMIZER,
    AD_SCHEDULE_BID_MULTIPLIER_MALFORMED,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_BIG,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_SMALL,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_MANY_FRACTION_DIGITS,
    AD_SCHEDULE_EXCEEDED_INTERVALS_PER_DAY_LIMIT,
    AD_SCHEDULE_EXCEEDS_PAST_END_OF_WEEK,
    AD_SCHEDULE_INCOMPATIBILITY,
    AD_SCHEDULE_INCOMPATIBLE_WITH_BUDGET_OPTIMIZER,
    AD_SCHEDULE_INTERVAL_CANNOT_SPAN_MULTIPLE_DAYS,
    AD_SCHEDULE_INVALID_DAY_OF_THE_WEEK,
    AD_SCHEDULE_INVALID_TIME_INTERVAL,
    AD_SCHEDULE_NO_INTERVALS_WHILE_ENABLED,
    AD_SCHEDULE_NOT_MULTIPLE_OF_15_MINUTES,
    AD_SCHEDULE_TIME_INTERVALS_OVERLAP,
    CANNOT_EXCLUDE_CITY,
    CANNOT_EXCLUDE_IF_NOT_TARGETED,
    CANNOT_EXCLUDE_METRO,
    CANNOT_EXCLUDE_PROVINCE,
    CANNOT_OPT_OUT_GOOGLE_SEARCH_WHILE_BID_TO_POSITION_ENABLE,
    CANNOT_TARGET_AGE_WITHOUT_GENDER,
    CANNOT_TARGET_CITY,
    CANNOT_TARGET_COUNTRY,
    CANNOT_TARGET_COVERAGE,
    CANNOT_TARGET_GENDER_WITHOUT_AGE,
    CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN,
    CANNOT_TARGET_LANGUAGE,
    CANNOT_TARGET_METRO,
    CANNOT_TARGET_PROVINCE,
    CANNOT_TARGET_SEARCH_SYNDICATION_WITHOUT_GOOGLE_SEARCH,
    CANNOT_TARGET_SYNDICATABLE_TYPES,
    DEMOGRAPHIC_BID_MODIFIER_SHOULD_BE_IN_BETWEEN_0_AND_500,
    INVALID_CITY_CODE,
    INVALID_CITYNAME_LENGTH,
    INVALID_LANGUAGE_CODE,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    INVALID_METRO_CODE,
    INVALID_POSTALCODE_LENGTH,
    INVALID_PROVINCE_CODE,
    INVALID_PROXIMITY_RADIUS,
    INVALID_REGIONCODE_LENGTH,
    INVALID_REGIONNAME_LENGTH,
    INVALID_STREETADDRESS_LENGTH,
    MULTIPLE_OCCURRENCES_OF_SAME_TARGET,
    POLYGON_DUPLICATE_VERTICES,
    POLYGON_EDGES_INTERSECT,
    POLYGON_TOO_FEW_VERTICES,
    POLYGON_TOO_LARGE,
    TARGET_IS_ENCLOSED_BY_ANOTHER_TARGET,
    TARGET_IS_EXCLUDED_BY_ANOTHER_TARGET,
    TARGETING_VALIDATION_FAILED,
    TARGETING_CROSS_COUNTRY_REGIONAL,
    TARGETING_EXCLUSION_NOT_SUPPORTED,
    TARGETING_INCOMPATIBLE_LOCATION_TYPES,
    TARGETING_NOT_SUPPORTED,
    TARGETING_TOO_MANY_REGIONS,
    TOO_MANY_EXCLUDED_LOCATIONS,
    TOO_MANY_TARGETED_LOCATIONS,
    WARNING_MAY_NOW_REQUIRE_CHINESE_APPROVAL,
    WARNING_NOW_REQUIRES_CHINESE_APPROVAL,
    WARNING_NOW_TARGETS_CHINA,
    WARNING_NOW_TARGETS_CHINESE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class StatsQueryError : ApiError {
    private StatsQueryErrorReason reasonField;

    private bool reasonFieldSpecified;

    public StatsQueryErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StatsQueryError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum StatsQueryErrorReason {
    DATE_NOT_IN_VALID_RANGE
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLimitExceeded))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdCountLimitExceeded))]
  public abstract partial class EntityCountLimitExceeded : ApiError {
    private EntityCountLimitExceededReason reasonField;

    private bool reasonFieldSpecified;

    private string enclosingIdField;

    private int limitField;

    private bool limitFieldSpecified;

    public EntityCountLimitExceededReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }

    public string enclosingId {
      get {
        return this.enclosingIdField;
      }
      set {
        this.enclosingIdField = value;
      }
    }

    public int limit {
      get {
        return this.limitField;
      }
      set {
        this.limitField = value;
        this.limitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitSpecified {
      get {
        return this.limitFieldSpecified;
      }
      set {
        this.limitFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityCountLimitExceeded.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum EntityCountLimitExceededReason {
    ACCOUNT_LIMIT,
    CAMPAIGN_LIMIT,
    ADGROUP_LIMIT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterionLimitExceeded : EntityCountLimitExceeded {
    private AdGroupCriterionLimitExceededCriteriaLimitType limitTypeField;

    private bool limitTypeFieldSpecified;

    public AdGroupCriterionLimitExceededCriteriaLimitType limitType {
      get {
        return this.limitTypeField;
      }
      set {
        this.limitTypeField = value;
        this.limitTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitTypeSpecified {
      get {
        return this.limitTypeFieldSpecified;
      }
      set {
        this.limitTypeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupCriterionLimitExceeded.CriteriaLimitType", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdGroupCriterionLimitExceededCriteriaLimitType {
    ADGROUP_KEYWORD,
    ADGROUP_WEBSITE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class DistinctError : ApiError {
    private DistinctErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DistinctErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DistinctError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum DistinctErrorReason {
    DUPLICATE_ELEMENT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class DateError : ApiError {
    private DateErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DateErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DateError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum DateErrorReason {
    INVALID_FIELD_VALUES_IN_DATE,
    INVALID_STRING_DATE,
    INVALID_STRING_DATE_RANGE,
    INVALID_STRING_DATE_TIME,
    EARLIER_THAN_MINIMUM_DATE,
    LATER_THAN_MAXIMUM_DATE,
    DATE_RANGE_MINIMUM_DATE_LATER_THAN_MAXIMUM_DATE,
    DATE_RANGE_MINIMUM_AND_MAXIMUM_DATES_BOTH_NULL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BudgetError : ApiError {
    private BudgetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BudgetErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BudgetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BudgetErrorReason {
    MONEY_AMOUNT_IN_WRONG_CURRENCY,
    MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC,
    MONEY_AMOUNT_LESS_THAN_MAXIMUM_AD_GROUP_CPM,
    MONEY_AMOUNT_LESS_THAN_MAXIMUM_SITE_CPM,
    MONEY_AMOUNT_LESS_THAN_MINIMUM_AD_GROUP_CPC,
    MONEY_AMOUNT_LESS_THAN_MINIMUM_CRITERIA_CPC,
    MONEY_AMOUNT_TOO_LARGE,
    NEGATIVE_MONEY_AMOUNT,
    NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT,
    INVALID_BUDGET_SCHEDULE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BiddingError : ApiError {
    private BiddingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BiddingErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BiddingErrorReason {
    BID_AMOUNT_REQUIRED,
    BID_INCOMPATIBLE_WITH_ADGROUP,
    BID_UNIVERSAL_CRITERIA_EXPECTED,
    BIDS_DO_NOT_FULFILL_SPEC,
    BID_TOO_SMALL,
    BID_TOO_BIG,
    BID_TOO_MANY_FRACTIONAL_DIGITS,
    NETWORK_NOT_OVERRIDEABLE,
    NON_POSITIVE_BID,
    CURRENCY_MISMATCH,
    BID_TOO_HIGH_FOR_DAILY_BUDGET,
    BID_TOO_HIGH_FOR_MONTHLY_BUDGET,
    ADGROUPS_DO_NOT_MATCH_CONSTRAINT,
    NETWORK_SETTINGS_DO_NOT_SUPPORT_TRANSITION,
    UNSUPPORTED_STYLE_TRANSITION,
    UNSUPPORTED_PROXY_BIDDER_STRATEGY_TRANSITION,
    TRANSITION_DOES_NOT_SUPPORT_OPTION,
    TRANSITION_DOES_NOT_SUPPORT_GOAL,
    PROXY_BIDDER_STRATEGY_INCOMPATIBLE_WITH_STYLE,
    GOAL_DOES_NOT_FULFILL_SPEC,
    GOAL_VALIDATION_FAILED,
    UNSUPPORTED_STYLE,
    BAD_BID_COMBINATION,
    CANNOT_TARGET_UNIVERSE,
    NO_DESTINATION_URL_SPECIFIED,
    NO_EFFECTIVE_BID,
    CRITERION_NOT_TARGETED,
    CANNOT_EXCLUDE_DEFAULT,
    CANNOT_TARGET_AND_EXCLUDE,
    ILLEGAL_URL,
    BID_TO_POSITION_NOT_ENABLED,
    POSITION_PREFERENCE_NOT_ENABLED,
    POSITION_PREFERENCE_NOT_SUPPORTED_FOR_CRITERIA_TYPE,
    PREFERRED_POSITION_OUT_OF_RANGE,
    BOTTOM_POSITION_OUT_OF_RANGE,
    PREFERRED_POSITION_CANNOT_BE_HIGHER_THAN_BOTTOM,
    CAMPAIGN_ALREADY_SET,
    PROXY_NOT_ENABLED,
    CANNOT_UPDATE_SITE_BIDS_WHILE_PROXY_BIDDING,
    MUST_EXCLUDE_0_TO_17_WITH_OTHER_AGE_EXCLUSIONS,
    AUCTION_STRATEGY_INCOMPATIBLE_WITH_PROXY_BIDDER,
    CAMPAIGN_MUST_HAVE_A_BUDGET_TO_ENABLE_BUDGET_OPTIMIZER,
    CANNOT_SET_CONTENT_BID_WITHOUT_SETTING_KEYWORD_MAX_CPC_AS_WELL,
    CANNOT_CREATE_CAMPAIGN_WITH_CONVERSION_OPTIMIZER,
    PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterionError : ApiError {
    private AdGroupCriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupCriterionErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupCriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdGroupCriterionErrorReason {
    INVALID_ID_FILTER_TYPE,
    ID_FILTERS_HAVE_DIFF_FIELDS_SET,
    INAPPLICABLE_FILTER_SPECIFIED,
    TOO_MANY_OPERTAIONS,
    CANT_UPDATE_NEGATIVE,
    TYPE_MISMATCH,
    CONCRETE_TYPE_REQUIRED,
    BID_INCOMPATIBLE_WITH_ADGROUP,
    NETWORK_NOT_OVERRIDABLE,
    CURRENCY_MISMATCH,
    CRITERION_NOT_TARGETED,
    CANNOT_TARGET_AND_EXCLUDE,
    ILLEGAL_URL,
    NO_EFFECTIVE_BID_FOR_THIS_CRITERION,
    INVALID_KEYWORD_TEXT,
    INVALID_DESTINATION_URL,
    KEYWORD_LEVEL_BID_NOT_SUPPORTED_FOR_MANUALCPM,
    INVALID_USER_STATUS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class TargetingIdeaError : ApiError {
    private TargetingIdeaErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TargetingIdeaErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TargetingIdeaError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum TargetingIdeaErrorReason {
    DUPLICATE_SEARCH_FILTER_TYPES_PRESENT,
    INSUFFICIENT_SEARCH_PARAMETERS,
    INVALID_ATTRIBUTE_TYPE,
    INVALID_SEARCH_PARAMETERS,
    MUTUALLY_EXCLUSIVE_SEARCH_PARAMETERS_IN_QUERY,
    SERVICE_UNAVAILABLE,
    INVALID_URL_IN_SEARCH_PARAMETER,
    TOO_MANY_RESULTS_REQUESTED,
    NO_PAGING_IN_SELECTOR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public partial class CollectionSizeError : ApiError {
    private CollectionSizeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CollectionSizeErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CollectionSizeError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v200909")]
  public enum CollectionSizeErrorReason {
    TOO_FEW,
    TOO_MANY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "BulkMutateJobServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobEvent))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobSelector))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class BulkMutateJobService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public BulkMutateJobService() {
      this.Url = "https://adwords.google.com/api/adwords/job/v200909/BulkMutateJobService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public BulkMutateJob[] get(BulkMutateJobSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((BulkMutateJob[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public BulkMutateJob mutate(JobOperation operation) {
      object[] results = this.Invoke("mutate", new object[] {operation});
      return ((BulkMutateJob) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class LocationOverrideInfo {
    private int radiusField;

    private bool radiusFieldSpecified;

    private LocationOverrideInfoRadiusUnits radiusUnitsField;

    private bool radiusUnitsFieldSpecified;

    public int radius {
      get {
        return this.radiusField;
      }
      set {
        this.radiusField = value;
        this.radiusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusSpecified {
      get {
        return this.radiusFieldSpecified;
      }
      set {
        this.radiusFieldSpecified = value;
      }
    }

    public LocationOverrideInfoRadiusUnits radiusUnits {
      get {
        return this.radiusUnitsField;
      }
      set {
        this.radiusUnitsField = value;
        this.radiusUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusUnitsSpecified {
      get {
        return this.radiusUnitsFieldSpecified;
      }
      set {
        this.radiusUnitsFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationOverrideInfo.RadiusUnits", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum LocationOverrideInfoRadiusUnits {
    KILOMETERS,
    MILES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class OverrideInfo {
    private LocationOverrideInfo itemField;

    [System.Xml.Serialization.XmlElementAttribute("LocationOverrideInfo")]
    public LocationOverrideInfo Item {
      get {
        return this.itemField;
      }
      set {
        this.itemField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationExtension))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtension {
    private long idField;

    private bool idFieldSpecified;

    private string adExtensionTypeField;

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

    [System.Xml.Serialization.XmlElementAttribute("AdExtension.Type")]
    public string AdExtensionType {
      get {
        return this.adExtensionTypeField;
      }
      set {
        this.adExtensionTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class LocationExtension : AdExtension {
    private Address addressField;

    private GeoPoint geoPointField;

    private byte[] encodedLocationField;

    private string companyNameField;

    private string phoneNumberField;

    private LocationExtensionSource sourceField;

    private bool sourceFieldSpecified;

    private long iconMediaIdField;

    private bool iconMediaIdFieldSpecified;

    private long imageMediaIdField;

    private bool imageMediaIdFieldSpecified;

    public Address address {
      get {
        return this.addressField;
      }
      set {
        this.addressField = value;
      }
    }

    public GeoPoint geoPoint {
      get {
        return this.geoPointField;
      }
      set {
        this.geoPointField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] encodedLocation {
      get {
        return this.encodedLocationField;
      }
      set {
        this.encodedLocationField = value;
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

    public string phoneNumber {
      get {
        return this.phoneNumberField;
      }
      set {
        this.phoneNumberField = value;
      }
    }

    public LocationExtensionSource source {
      get {
        return this.sourceField;
      }
      set {
        this.sourceField = value;
        this.sourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sourceSpecified {
      get {
        return this.sourceFieldSpecified;
      }
      set {
        this.sourceFieldSpecified = value;
      }
    }

    public long iconMediaId {
      get {
        return this.iconMediaIdField;
      }
      set {
        this.iconMediaIdField = value;
        this.iconMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool iconMediaIdSpecified {
      get {
        return this.iconMediaIdFieldSpecified;
      }
      set {
        this.iconMediaIdFieldSpecified = value;
      }
    }

    public long imageMediaId {
      get {
        return this.imageMediaIdField;
      }
      set {
        this.imageMediaIdField = value;
        this.imageMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool imageMediaIdSpecified {
      get {
        return this.imageMediaIdFieldSpecified;
      }
      set {
        this.imageMediaIdFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationExtension.Source", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum LocationExtensionSource {
    ADWORDS_FRONTEND,
    LBC_SYNC
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionOverride {
    private long adIdField;

    private bool adIdFieldSpecified;

    private AdExtension adExtensionField;

    private OverrideInfo overrideInfoField;

    private AdExtensionOverrideStatus statusField;

    private bool statusFieldSpecified;

    private AdExtensionOverrideApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private AdExtensionOverrideStats statsField;

    public long adId {
      get {
        return this.adIdField;
      }
      set {
        this.adIdField = value;
        this.adIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adIdSpecified {
      get {
        return this.adIdFieldSpecified;
      }
      set {
        this.adIdFieldSpecified = value;
      }
    }

    public AdExtension adExtension {
      get {
        return this.adExtensionField;
      }
      set {
        this.adExtensionField = value;
      }
    }

    public OverrideInfo overrideInfo {
      get {
        return this.overrideInfoField;
      }
      set {
        this.overrideInfoField = value;
      }
    }

    public AdExtensionOverrideStatus status {
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

    public AdExtensionOverrideApprovalStatus approvalStatus {
      get {
        return this.approvalStatusField;
      }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get {
        return this.approvalStatusFieldSpecified;
      }
      set {
        this.approvalStatusFieldSpecified = value;
      }
    }

    public AdExtensionOverrideStats stats {
      get {
        return this.statsField;
      }
      set {
        this.statsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionOverride.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdExtensionOverrideStatus {
    ACTIVE,
    DELETED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionOverride.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdExtensionOverrideApprovalStatus {
    APPROVED,
    UNCHECKED,
    DISAPPROVED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionOverrideStats : Stats {
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdStats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideStats))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Stats {
    private string startDateField;

    private string endDateField;

    private StatsNetwork networkField;

    private bool networkFieldSpecified;

    private long clicksField;

    private bool clicksFieldSpecified;

    private long impressionsField;

    private bool impressionsFieldSpecified;

    private Money costField;

    private double averagePositionField;

    private bool averagePositionFieldSpecified;

    private Money averageCpcField;

    private Money averageCpmField;

    private double ctrField;

    private bool ctrFieldSpecified;

    private long conversionsField;

    private bool conversionsFieldSpecified;

    private double conversionRateField;

    private bool conversionRateFieldSpecified;

    private Money costPerConversionField;

    private long conversionsManyPerClickField;

    private bool conversionsManyPerClickFieldSpecified;

    private double conversionRateManyPerClickField;

    private bool conversionRateManyPerClickFieldSpecified;

    private Money costPerConversionManyPerClickField;

    private string statsTypeField;

    public string startDate {
      get {
        return this.startDateField;
      }
      set {
        this.startDateField = value;
      }
    }

    public string endDate {
      get {
        return this.endDateField;
      }
      set {
        this.endDateField = value;
      }
    }

    public StatsNetwork network {
      get {
        return this.networkField;
      }
      set {
        this.networkField = value;
        this.networkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool networkSpecified {
      get {
        return this.networkFieldSpecified;
      }
      set {
        this.networkFieldSpecified = value;
      }
    }

    public long clicks {
      get {
        return this.clicksField;
      }
      set {
        this.clicksField = value;
        this.clicksSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clicksSpecified {
      get {
        return this.clicksFieldSpecified;
      }
      set {
        this.clicksFieldSpecified = value;
      }
    }

    public long impressions {
      get {
        return this.impressionsField;
      }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get {
        return this.impressionsFieldSpecified;
      }
      set {
        this.impressionsFieldSpecified = value;
      }
    }

    public Money cost {
      get {
        return this.costField;
      }
      set {
        this.costField = value;
      }
    }

    public double averagePosition {
      get {
        return this.averagePositionField;
      }
      set {
        this.averagePositionField = value;
        this.averagePositionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool averagePositionSpecified {
      get {
        return this.averagePositionFieldSpecified;
      }
      set {
        this.averagePositionFieldSpecified = value;
      }
    }

    public Money averageCpc {
      get {
        return this.averageCpcField;
      }
      set {
        this.averageCpcField = value;
      }
    }

    public Money averageCpm {
      get {
        return this.averageCpmField;
      }
      set {
        this.averageCpmField = value;
      }
    }

    public double ctr {
      get {
        return this.ctrField;
      }
      set {
        this.ctrField = value;
        this.ctrSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ctrSpecified {
      get {
        return this.ctrFieldSpecified;
      }
      set {
        this.ctrFieldSpecified = value;
      }
    }

    public long conversions {
      get {
        return this.conversionsField;
      }
      set {
        this.conversionsField = value;
        this.conversionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionsSpecified {
      get {
        return this.conversionsFieldSpecified;
      }
      set {
        this.conversionsFieldSpecified = value;
      }
    }

    public double conversionRate {
      get {
        return this.conversionRateField;
      }
      set {
        this.conversionRateField = value;
        this.conversionRateSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionRateSpecified {
      get {
        return this.conversionRateFieldSpecified;
      }
      set {
        this.conversionRateFieldSpecified = value;
      }
    }

    public Money costPerConversion {
      get {
        return this.costPerConversionField;
      }
      set {
        this.costPerConversionField = value;
      }
    }

    public long conversionsManyPerClick {
      get {
        return this.conversionsManyPerClickField;
      }
      set {
        this.conversionsManyPerClickField = value;
        this.conversionsManyPerClickSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionsManyPerClickSpecified {
      get {
        return this.conversionsManyPerClickFieldSpecified;
      }
      set {
        this.conversionsManyPerClickFieldSpecified = value;
      }
    }

    public double conversionRateManyPerClick {
      get {
        return this.conversionRateManyPerClickField;
      }
      set {
        this.conversionRateManyPerClickField = value;
        this.conversionRateManyPerClickSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionRateManyPerClickSpecified {
      get {
        return this.conversionRateManyPerClickFieldSpecified;
      }
      set {
        this.conversionRateManyPerClickFieldSpecified = value;
      }
    }

    public Money costPerConversionManyPerClick {
      get {
        return this.costPerConversionManyPerClickField;
      }
      set {
        this.costPerConversionManyPerClickField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Stats.Type")]
    public string StatsType {
      get {
        return this.statsTypeField;
      }
      set {
        this.statsTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Stats.Network", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum StatsNetwork {
    SEARCH,
    GOOGLE_SEARCH,
    SEARCH_NETWORK,
    CONTENT,
    CONTENT_KEYWORD_BID,
    CONTENT_PLACEMENT_BID,
    ALL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdStats : Stats {
    private double percentServedField;

    private bool percentServedFieldSpecified;

    public double percentServed {
      get {
        return this.percentServedField;
      }
      set {
        this.percentServedField = value;
        this.percentServedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool percentServedSpecified {
      get {
        return this.percentServedFieldSpecified;
      }
      set {
        this.percentServedFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Operand {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("Ad", typeof(Ad))]
    [System.Xml.Serialization.XmlElementAttribute("AdExtensionOverride", typeof(AdExtensionOverride))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroup", typeof(AdGroup))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupAd", typeof(AdGroupAd))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterion", typeof(AdGroupCriterion))]
    [System.Xml.Serialization.XmlElementAttribute("Campaign", typeof(Campaign))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterion", typeof(CampaignCriterion))]
    [System.Xml.Serialization.XmlElementAttribute("Job", typeof(Job))]
    [System.Xml.Serialization.XmlElementAttribute("Media", typeof(Media))]
    [System.Xml.Serialization.XmlElementAttribute("Target", typeof(Target))]
    [System.Xml.Serialization.XmlElementAttribute("TargetList", typeof(TargetList))]
    public object Item {
      get {
        return this.itemField;
      }
      set {
        this.itemField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemplateAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileImageAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalBusinessAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeprecatedAd))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Ad {
    private long idField;

    private bool idFieldSpecified;

    private string urlField;

    private string displayUrlField;

    private AdApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private string[] disapprovalReasonsField;

    private string adTypeField;

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

    public string url {
      get {
        return this.urlField;
      }
      set {
        this.urlField = value;
      }
    }

    public string displayUrl {
      get {
        return this.displayUrlField;
      }
      set {
        this.displayUrlField = value;
      }
    }

    public AdApprovalStatus approvalStatus {
      get {
        return this.approvalStatusField;
      }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get {
        return this.approvalStatusFieldSpecified;
      }
      set {
        this.approvalStatusFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("disapprovalReasons")]
    public string[] disapprovalReasons {
      get {
        return this.disapprovalReasonsField;
      }
      set {
        this.disapprovalReasonsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Ad.Type")]
    public string AdType {
      get {
        return this.adTypeField;
      }
      set {
        this.adTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Ad.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdApprovalStatus {
    APPROVED,
    FAMILY_SAFE,
    NON_FAMILY_SAFE,
    PORN,
    UNCHECKED,
    DISAPPROVED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class TextAd : Ad {
    private string headlineField;

    private string description1Field;

    private string description2Field;

    public string headline {
      get {
        return this.headlineField;
      }
      set {
        this.headlineField = value;
      }
    }

    public string description1 {
      get {
        return this.description1Field;
      }
      set {
        this.description1Field = value;
      }
    }

    public string description2 {
      get {
        return this.description2Field;
      }
      set {
        this.description2Field = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class TemplateAd : Ad {
    private long templateIdField;

    private bool templateIdFieldSpecified;

    private AdUnionId adUnionIdField;

    private TemplateElement[] templateElementsField;

    private Dimensions dimensionsField;

    private string nameField;

    private int durationField;

    private bool durationFieldSpecified;

    public long templateId {
      get {
        return this.templateIdField;
      }
      set {
        this.templateIdField = value;
        this.templateIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool templateIdSpecified {
      get {
        return this.templateIdFieldSpecified;
      }
      set {
        this.templateIdFieldSpecified = value;
      }
    }

    public AdUnionId adUnionId {
      get {
        return this.adUnionIdField;
      }
      set {
        this.adUnionIdField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("templateElements")]
    public TemplateElement[] templateElements {
      get {
        return this.templateElementsField;
      }
      set {
        this.templateElementsField = value;
      }
    }

    public Dimensions dimensions {
      get {
        return this.dimensionsField;
      }
      set {
        this.dimensionsField = value;
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

    public int duration {
      get {
        return this.durationField;
      }
      set {
        this.durationField = value;
        this.durationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationSpecified {
      get {
        return this.durationFieldSpecified;
      }
      set {
        this.durationFieldSpecified = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TempAdUnionId))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdUnionId {
    private long idField;

    private bool idFieldSpecified;

    private string adUnionIdTypeField;

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

    [System.Xml.Serialization.XmlElementAttribute("AdUnionId.Type")]
    public string AdUnionIdType {
      get {
        return this.adUnionIdTypeField;
      }
      set {
        this.adUnionIdTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class TempAdUnionId : AdUnionId {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class TemplateElement {
    private string uniqueNameField;

    private TemplateElementField[] fieldsField;

    public string uniqueName {
      get {
        return this.uniqueNameField;
      }
      set {
        this.uniqueNameField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("fields")]
    public TemplateElementField[] fields {
      get {
        return this.fieldsField;
      }
      set {
        this.fieldsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class TemplateElementField {
    private string nameField;

    private TemplateElementFieldType typeField;

    private bool typeFieldSpecified;

    private string fieldTextField;

    private Media fieldMediaField;

    public string name {
      get {
        return this.nameField;
      }
      set {
        this.nameField = value;
      }
    }

    public TemplateElementFieldType type {
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

    public string fieldText {
      get {
        return this.fieldTextField;
      }
      set {
        this.fieldTextField = value;
      }
    }

    public Media fieldMedia {
      get {
        return this.fieldMediaField;
      }
      set {
        this.fieldMediaField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TemplateElementField.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum TemplateElementFieldType {
    ADDRESS,
    AUDIO,
    ENUM,
    IMAGE,
    TEXT,
    URL,
    VIDEO,
    VISIBLE_URL
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Video))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Image))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Audio))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Media {
    private long mediaIdField;

    private bool mediaIdFieldSpecified;

    private MediaMediaType mediaTypeDbField;

    private bool mediaTypeDbFieldSpecified;

    private long referenceIdField;

    private bool referenceIdFieldSpecified;

    private Media_Size_DimensionsMapEntry[] dimensionsField;

    private Media_Size_StringMapEntry[] urlsField;

    private MediaMimeType mimeTypeField;

    private bool mimeTypeFieldSpecified;

    private string sourceUrlField;

    private MediaMediaSubType mediaSubTypeField;

    private bool mediaSubTypeFieldSpecified;

    private string nameField;

    private long fileSizeField;

    private bool fileSizeFieldSpecified;

    private Media_MediaExtendedCapabilityType_Media_MediaExtendedCapabilityStateMapEntry[] extendedCapabilitiesField;

    private string creationTimeField;

    private string mediaTypeField;

    public long mediaId {
      get {
        return this.mediaIdField;
      }
      set {
        this.mediaIdField = value;
        this.mediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mediaIdSpecified {
      get {
        return this.mediaIdFieldSpecified;
      }
      set {
        this.mediaIdFieldSpecified = value;
      }
    }

    public MediaMediaType mediaTypeDb {
      get {
        return this.mediaTypeDbField;
      }
      set {
        this.mediaTypeDbField = value;
        this.mediaTypeDbSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mediaTypeDbSpecified {
      get {
        return this.mediaTypeDbFieldSpecified;
      }
      set {
        this.mediaTypeDbFieldSpecified = value;
      }
    }

    public long referenceId {
      get {
        return this.referenceIdField;
      }
      set {
        this.referenceIdField = value;
        this.referenceIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool referenceIdSpecified {
      get {
        return this.referenceIdFieldSpecified;
      }
      set {
        this.referenceIdFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("dimensions")]
    public Media_Size_DimensionsMapEntry[] dimensions {
      get {
        return this.dimensionsField;
      }
      set {
        this.dimensionsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("urls")]
    public Media_Size_StringMapEntry[] urls {
      get {
        return this.urlsField;
      }
      set {
        this.urlsField = value;
      }
    }

    public MediaMimeType mimeType {
      get {
        return this.mimeTypeField;
      }
      set {
        this.mimeTypeField = value;
        this.mimeTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mimeTypeSpecified {
      get {
        return this.mimeTypeFieldSpecified;
      }
      set {
        this.mimeTypeFieldSpecified = value;
      }
    }

    public string sourceUrl {
      get {
        return this.sourceUrlField;
      }
      set {
        this.sourceUrlField = value;
      }
    }

    public MediaMediaSubType mediaSubType {
      get {
        return this.mediaSubTypeField;
      }
      set {
        this.mediaSubTypeField = value;
        this.mediaSubTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mediaSubTypeSpecified {
      get {
        return this.mediaSubTypeFieldSpecified;
      }
      set {
        this.mediaSubTypeFieldSpecified = value;
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

    public long fileSize {
      get {
        return this.fileSizeField;
      }
      set {
        this.fileSizeField = value;
        this.fileSizeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool fileSizeSpecified {
      get {
        return this.fileSizeFieldSpecified;
      }
      set {
        this.fileSizeFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("extendedCapabilities")]
    public Media_MediaExtendedCapabilityType_Media_MediaExtendedCapabilityStateMapEntry[] extendedCapabilities {
      get {
        return this.extendedCapabilitiesField;
      }
      set {
        this.extendedCapabilitiesField = value;
      }
    }

    public string creationTime {
      get {
        return this.creationTimeField;
      }
      set {
        this.creationTimeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Media.Type")]
    public string MediaType {
      get {
        return this.mediaTypeField;
      }
      set {
        this.mediaTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MediaType", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MediaMediaType {
    AUDIO,
    DYNAMIC_IMAGE,
    HTML,
    ICON,
    IMAGE,
    STANDARD_ICON,
    VIDEO,
    VIDEO_IMAGE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Media_Size_DimensionsMapEntry {
    private MediaSize keyField;

    private bool keyFieldSpecified;

    private Dimensions valueField;

    public MediaSize key {
      get {
        return this.keyField;
      }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get {
        return this.keyFieldSpecified;
      }
      set {
        this.keyFieldSpecified = value;
      }
    }

    public Dimensions value {
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
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.Size", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MediaSize {
    FULL,
    SHRUNKEN,
    PREVIEW,
    VIDEO_THUMBNAIL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Dimensions {
    private int widthField;

    private bool widthFieldSpecified;

    private int heightField;

    private bool heightFieldSpecified;

    public int width {
      get {
        return this.widthField;
      }
      set {
        this.widthField = value;
        this.widthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool widthSpecified {
      get {
        return this.widthFieldSpecified;
      }
      set {
        this.widthFieldSpecified = value;
      }
    }

    public int height {
      get {
        return this.heightField;
      }
      set {
        this.heightField = value;
        this.heightSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool heightSpecified {
      get {
        return this.heightFieldSpecified;
      }
      set {
        this.heightFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Media_Size_StringMapEntry {
    private MediaSize keyField;

    private bool keyFieldSpecified;

    private string valueField;

    public MediaSize key {
      get {
        return this.keyField;
      }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get {
        return this.keyFieldSpecified;
      }
      set {
        this.keyFieldSpecified = value;
      }
    }

    public string value {
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
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MimeType", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MediaMimeType {
    IMAGE_JPEG,
    IMAGE_GIF,
    IMAGE_PNG,
    FLASH,
    TEXT_HTML,
    PDF,
    MSWORD,
    MSEXCEL,
    RTF,
    AUDIO_WAV,
    AUDIO_MP3
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MediaSubType", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MediaMediaSubType {
    GOOGLE_HOSTED,
    YOU_TUBE_HOSTED,
    IRS_STORED,
    ADS_DB_STORED,
    AMS_STORED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Media_MediaExtendedCapabilityType_Media_MediaExtendedCapabilityStateMapEntry {
    private MediaMediaExtendedCapabilityType keyField;

    private bool keyFieldSpecified;

    private MediaMediaExtendedCapabilityState valueField;

    private bool valueFieldSpecified;

    public MediaMediaExtendedCapabilityType key {
      get {
        return this.keyField;
      }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get {
        return this.keyFieldSpecified;
      }
      set {
        this.keyFieldSpecified = value;
      }
    }

    public MediaMediaExtendedCapabilityState value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MediaExtendedCapabilityType", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MediaMediaExtendedCapabilityType {
    MPEG2_PROGRAM_STREAM_SD,
    MPEG2_PROGRAM_STREAM_SD_WITH_BLACK,
    MPEG2_TRANSPORT_STREAM_SD,
    GXF_SD,
    FLV_320
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MediaExtendedCapabilityState", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MediaMediaExtendedCapabilityState {
    UNKNOWN,
    SUPPORTED,
    NOT_SUPPORTED,
    PASSED_PREREQ,
    FAILED_PREREQ,
    MEETS_CRITERIA
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Video : Media {
    private long durationMillisField;

    private bool durationMillisFieldSpecified;

    private string streamingUrlField;

    private bool readyToPlayOnTheWebField;

    private bool readyToPlayOnTheWebFieldSpecified;

    private string industryStandardCommercialIdentifierField;

    private string advertisingIdField;

    public long durationMillis {
      get {
        return this.durationMillisField;
      }
      set {
        this.durationMillisField = value;
        this.durationMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationMillisSpecified {
      get {
        return this.durationMillisFieldSpecified;
      }
      set {
        this.durationMillisFieldSpecified = value;
      }
    }

    public string streamingUrl {
      get {
        return this.streamingUrlField;
      }
      set {
        this.streamingUrlField = value;
      }
    }

    public bool readyToPlayOnTheWeb {
      get {
        return this.readyToPlayOnTheWebField;
      }
      set {
        this.readyToPlayOnTheWebField = value;
        this.readyToPlayOnTheWebSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool readyToPlayOnTheWebSpecified {
      get {
        return this.readyToPlayOnTheWebFieldSpecified;
      }
      set {
        this.readyToPlayOnTheWebFieldSpecified = value;
      }
    }

    public string industryStandardCommercialIdentifier {
      get {
        return this.industryStandardCommercialIdentifierField;
      }
      set {
        this.industryStandardCommercialIdentifierField = value;
      }
    }

    public string advertisingId {
      get {
        return this.advertisingIdField;
      }
      set {
        this.advertisingIdField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Image : Media {
    private byte[] dataField;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] data {
      get {
        return this.dataField;
      }
      set {
        this.dataField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Audio : Media {
    private long durationMillisField;

    private bool durationMillisFieldSpecified;

    private string streamingUrlField;

    private bool readyToPlayOnTheWebField;

    private bool readyToPlayOnTheWebFieldSpecified;

    public long durationMillis {
      get {
        return this.durationMillisField;
      }
      set {
        this.durationMillisField = value;
        this.durationMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationMillisSpecified {
      get {
        return this.durationMillisFieldSpecified;
      }
      set {
        this.durationMillisFieldSpecified = value;
      }
    }

    public string streamingUrl {
      get {
        return this.streamingUrlField;
      }
      set {
        this.streamingUrlField = value;
      }
    }

    public bool readyToPlayOnTheWeb {
      get {
        return this.readyToPlayOnTheWebField;
      }
      set {
        this.readyToPlayOnTheWebField = value;
        this.readyToPlayOnTheWebSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool readyToPlayOnTheWebSpecified {
      get {
        return this.readyToPlayOnTheWebFieldSpecified;
      }
      set {
        this.readyToPlayOnTheWebFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class MobileImageAd : Ad {
    private MarkupLanguageType[] markupLanguagesField;

    private string[] mobileCarriersField;

    private Image imageField;

    [System.Xml.Serialization.XmlElementAttribute("markupLanguages")]
    public MarkupLanguageType[] markupLanguages {
      get {
        return this.markupLanguagesField;
      }
      set {
        this.markupLanguagesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("mobileCarriers")]
    public string[] mobileCarriers {
      get {
        return this.mobileCarriersField;
      }
      set {
        this.mobileCarriersField = value;
      }
    }

    public Image image {
      get {
        return this.imageField;
      }
      set {
        this.imageField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MarkupLanguageType {
    HTML,
    CHTML,
    XHTML,
    WML
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class MobileAd : Ad {
    private string headlineField;

    private string descriptionField;

    private MarkupLanguageType[] markupLanguagesField;

    private string[] mobileCarriersField;

    private string businessNameField;

    private string countryCodeField;

    private string phoneNumberField;

    public string headline {
      get {
        return this.headlineField;
      }
      set {
        this.headlineField = value;
      }
    }

    public string description {
      get {
        return this.descriptionField;
      }
      set {
        this.descriptionField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("markupLanguages")]
    public MarkupLanguageType[] markupLanguages {
      get {
        return this.markupLanguagesField;
      }
      set {
        this.markupLanguagesField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("mobileCarriers")]
    public string[] mobileCarriers {
      get {
        return this.mobileCarriersField;
      }
      set {
        this.mobileCarriersField = value;
      }
    }

    public string businessName {
      get {
        return this.businessNameField;
      }
      set {
        this.businessNameField = value;
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

    public string phoneNumber {
      get {
        return this.phoneNumberField;
      }
      set {
        this.phoneNumberField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class LocalBusinessAd : Ad {
    private string fullBusinessNameField;

    private string phoneNumberField;

    private string streetAddressField;

    private string cityField;

    private string regionField;

    private string regionCodeField;

    private string postalCodeField;

    private string countryCodeField;

    private string businessNameField;

    private string description1Field;

    private string description2Field;

    private ProximityTarget targetField;

    private Image businessImageField;

    private Image iconField;

    public string fullBusinessName {
      get {
        return this.fullBusinessNameField;
      }
      set {
        this.fullBusinessNameField = value;
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

    public string streetAddress {
      get {
        return this.streetAddressField;
      }
      set {
        this.streetAddressField = value;
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

    public string region {
      get {
        return this.regionField;
      }
      set {
        this.regionField = value;
      }
    }

    public string regionCode {
      get {
        return this.regionCodeField;
      }
      set {
        this.regionCodeField = value;
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

    public string countryCode {
      get {
        return this.countryCodeField;
      }
      set {
        this.countryCodeField = value;
      }
    }

    public string businessName {
      get {
        return this.businessNameField;
      }
      set {
        this.businessNameField = value;
      }
    }

    public string description1 {
      get {
        return this.description1Field;
      }
      set {
        this.description1Field = value;
      }
    }

    public string description2 {
      get {
        return this.description2Field;
      }
      set {
        this.description2Field = value;
      }
    }

    public ProximityTarget target {
      get {
        return this.targetField;
      }
      set {
        this.targetField = value;
      }
    }

    public Image businessImage {
      get {
        return this.businessImageField;
      }
      set {
        this.businessImageField = value;
      }
    }

    public Image icon {
      get {
        return this.iconField;
      }
      set {
        this.iconField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ImageAd : Ad {
    private Image imageField;

    private string nameField;

    public Image image {
      get {
        return this.imageField;
      }
      set {
        this.imageField = value;
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
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class DeprecatedAd : Ad {
    private string nameField;

    private DeprecatedAdType typeField;

    private bool typeFieldSpecified;

    public string name {
      get {
        return this.nameField;
      }
      set {
        this.nameField = value;
      }
    }

    public DeprecatedAdType type {
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
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DeprecatedAd.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum DeprecatedAdType {
    VIDEO,
    CLICK_TO_CALL,
    IN_STREAM_VIDEO,
    FROOGLE,
    TEXT_LINK,
    GADGET,
    PRINT,
    TEXT_WIDE,
    GADGET_TEMPLATE,
    TEXT_WITH_VIDEO,
    AUDIO
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroup {
    private long idField;

    private bool idFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string campaignNameField;

    private string nameField;

    private AdGroupStatus statusField;

    private bool statusFieldSpecified;

    private AdGroupBids bidsField;

    private Stats statsField;

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

    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    public string campaignName {
      get {
        return this.campaignNameField;
      }
      set {
        this.campaignNameField = value;
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

    public AdGroupStatus status {
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

    public AdGroupBids bids {
      get {
        return this.bidsField;
      }
      set {
        this.bidsField = value;
      }
    }

    public Stats stats {
      get {
        return this.statsField;
      }
      set {
        this.statsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroup.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdGroupStatus {
    ENABLED,
    PAUSED,
    DELETED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPMAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizerAdGroupBids))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class AdGroupBids {
    private string adGroupBidsTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupBids.Type")]
    public string AdGroupBidsType {
      get {
        return this.adGroupBidsTypeField;
      }
      set {
        this.adGroupBidsTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ManualCPMAdGroupBids : AdGroupBids {
    private Bid maxCpmField;

    public Bid maxCpm {
      get {
        return this.maxCpmField;
      }
      set {
        this.maxCpmField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Bid {
    private Money amountField;

    public Money amount {
      get {
        return this.amountField;
      }
      set {
        this.amountField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ManualCPCAdGroupBids : AdGroupBids {
    private Bid keywordMaxCpcField;

    private Bid keywordContentMaxCpcField;

    private Bid siteMaxCpcField;

    public Bid keywordMaxCpc {
      get {
        return this.keywordMaxCpcField;
      }
      set {
        this.keywordMaxCpcField = value;
      }
    }

    public Bid keywordContentMaxCpc {
      get {
        return this.keywordContentMaxCpcField;
      }
      set {
        this.keywordContentMaxCpcField = value;
      }
    }

    public Bid siteMaxCpc {
      get {
        return this.siteMaxCpcField;
      }
      set {
        this.siteMaxCpcField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ConversionOptimizerAdGroupBids : AdGroupBids {
    private Bid targetCpaField;

    public Bid targetCpa {
      get {
        return this.targetCpaField;
      }
      set {
        this.targetCpaField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BudgetOptimizerAdGroupBids : AdGroupBids {
    private Bid proxyKeywordMaxCpcField;

    private Bid proxySiteMaxCpcField;

    public Bid proxyKeywordMaxCpc {
      get {
        return this.proxyKeywordMaxCpcField;
      }
      set {
        this.proxyKeywordMaxCpcField = value;
      }
    }

    public Bid proxySiteMaxCpc {
      get {
        return this.proxySiteMaxCpcField;
      }
      set {
        this.proxySiteMaxCpcField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupAd {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private Ad adField;

    private AdGroupAdStatus statusField;

    private bool statusFieldSpecified;

    private AdStats statsField;

    public long adGroupId {
      get {
        return this.adGroupIdField;
      }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get {
        return this.adGroupIdFieldSpecified;
      }
      set {
        this.adGroupIdFieldSpecified = value;
      }
    }

    public Ad ad {
      get {
        return this.adField;
      }
      set {
        this.adField = value;
      }
    }

    public AdGroupAdStatus status {
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

    public AdStats stats {
      get {
        return this.statsField;
      }
      set {
        this.statsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupAd.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdGroupAdStatus {
    ENABLED,
    PAUSED,
    DISABLED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeAdGroupCriterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddableAdGroupCriterion))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterion {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private Criterion criterionField;

    private string adGroupCriterionTypeField;

    public long adGroupId {
      get {
        return this.adGroupIdField;
      }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get {
        return this.adGroupIdFieldSpecified;
      }
      set {
        this.adGroupIdFieldSpecified = value;
      }
    }

    public Criterion criterion {
      get {
        return this.criterionField;
      }
      set {
        this.criterionField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterion.Type")]
    public string AdGroupCriterionType {
      get {
        return this.adGroupCriterionTypeField;
      }
      set {
        this.adGroupCriterionTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ContentLabel : Criterion {
    private ContentLabelType contentLabelTypeField;

    private bool contentLabelTypeFieldSpecified;

    public ContentLabelType contentLabelType {
      get {
        return this.contentLabelTypeField;
      }
      set {
        this.contentLabelTypeField = value;
        this.contentLabelTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool contentLabelTypeSpecified {
      get {
        return this.contentLabelTypeFieldSpecified;
      }
      set {
        this.contentLabelTypeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum ContentLabelType {
    ADULTISH,
    AFE,
    CONFLICT,
    CONFLICT_TRAGEDY,
    DP,
    EDGY,
    EMBEDDED_VIDEO,
    GAMES,
    JACKASS,
    PROFANITY,
    UGC,
    UGC_FORUMS,
    UGC_IMAGES,
    UGC_SOCIAL,
    UGC_VIDEOS,
    SENSITIVE,
    SIRENS,
    TRAGEDY,
    VIDEO
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NegativeAdGroupCriterion : AdGroupCriterion {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BiddableAdGroupCriterion : AdGroupCriterion {
    private UserStatus userStatusField;

    private bool userStatusFieldSpecified;

    private SystemServingStatus systemServingStatusField;

    private bool systemServingStatusFieldSpecified;

    private ApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private string destinationUrlField;

    private AdGroupCriterionBids bidsField;

    private Bid firstPageCpcField;

    private QualityInfo qualityInfoField;

    private Stats statsField;

    public UserStatus userStatus {
      get {
        return this.userStatusField;
      }
      set {
        this.userStatusField = value;
        this.userStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userStatusSpecified {
      get {
        return this.userStatusFieldSpecified;
      }
      set {
        this.userStatusFieldSpecified = value;
      }
    }

    public SystemServingStatus systemServingStatus {
      get {
        return this.systemServingStatusField;
      }
      set {
        this.systemServingStatusField = value;
        this.systemServingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool systemServingStatusSpecified {
      get {
        return this.systemServingStatusFieldSpecified;
      }
      set {
        this.systemServingStatusFieldSpecified = value;
      }
    }

    public ApprovalStatus approvalStatus {
      get {
        return this.approvalStatusField;
      }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get {
        return this.approvalStatusFieldSpecified;
      }
      set {
        this.approvalStatusFieldSpecified = value;
      }
    }

    public string destinationUrl {
      get {
        return this.destinationUrlField;
      }
      set {
        this.destinationUrlField = value;
      }
    }

    public AdGroupCriterionBids bids {
      get {
        return this.bidsField;
      }
      set {
        this.bidsField = value;
      }
    }

    public Bid firstPageCpc {
      get {
        return this.firstPageCpcField;
      }
      set {
        this.firstPageCpcField = value;
      }
    }

    public QualityInfo qualityInfo {
      get {
        return this.qualityInfoField;
      }
      set {
        this.qualityInfoField = value;
      }
    }

    public Stats stats {
      get {
        return this.statsField;
      }
      set {
        this.statsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum UserStatus {
    ACTIVE,
    DELETED,
    PAUSED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum SystemServingStatus {
    ELIGIBLE,
    RARELY_SERVED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum ApprovalStatus {
    APPROVED,
    PENDING_REVIEW,
    UNDER_REVIEW,
    DISAPPROVED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPMAdGroupCriterionBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupCriterionBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerAdGroupCriterionBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizerAdGroupCriterionBids))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class AdGroupCriterionBids {
    private string adGroupCriterionBidsTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionBids.Type")]
    public string AdGroupCriterionBidsType {
      get {
        return this.adGroupCriterionBidsTypeField;
      }
      set {
        this.adGroupCriterionBidsTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ManualCPMAdGroupCriterionBids : AdGroupCriterionBids {
    private Bid maxCpmField;

    private BidSource bidSourceField;

    private bool bidSourceFieldSpecified;

    public Bid maxCpm {
      get {
        return this.maxCpmField;
      }
      set {
        this.maxCpmField = value;
      }
    }

    public BidSource bidSource {
      get {
        return this.bidSourceField;
      }
      set {
        this.bidSourceField = value;
        this.bidSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidSourceSpecified {
      get {
        return this.bidSourceFieldSpecified;
      }
      set {
        this.bidSourceFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BidSource {
    ADGROUP,
    CRITERION
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ManualCPCAdGroupCriterionBids : AdGroupCriterionBids {
    private Bid maxCpcField;

    private BidSource bidSourceField;

    private bool bidSourceFieldSpecified;

    private PositionPreferenceAdGroupCriterionBids positionPreferenceBidsField;

    public Bid maxCpc {
      get {
        return this.maxCpcField;
      }
      set {
        this.maxCpcField = value;
      }
    }

    public BidSource bidSource {
      get {
        return this.bidSourceField;
      }
      set {
        this.bidSourceField = value;
        this.bidSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidSourceSpecified {
      get {
        return this.bidSourceFieldSpecified;
      }
      set {
        this.bidSourceFieldSpecified = value;
      }
    }

    public PositionPreferenceAdGroupCriterionBids positionPreferenceBids {
      get {
        return this.positionPreferenceBidsField;
      }
      set {
        this.positionPreferenceBidsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class PositionPreferenceAdGroupCriterionBids {
    private Bid proxyMaxCpcField;

    private int preferredPositionField;

    private bool preferredPositionFieldSpecified;

    private int bottomPositionField;

    private bool bottomPositionFieldSpecified;

    public Bid proxyMaxCpc {
      get {
        return this.proxyMaxCpcField;
      }
      set {
        this.proxyMaxCpcField = value;
      }
    }

    public int preferredPosition {
      get {
        return this.preferredPositionField;
      }
      set {
        this.preferredPositionField = value;
        this.preferredPositionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool preferredPositionSpecified {
      get {
        return this.preferredPositionFieldSpecified;
      }
      set {
        this.preferredPositionFieldSpecified = value;
      }
    }

    public int bottomPosition {
      get {
        return this.bottomPositionField;
      }
      set {
        this.bottomPositionField = value;
        this.bottomPositionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bottomPositionSpecified {
      get {
        return this.bottomPositionFieldSpecified;
      }
      set {
        this.bottomPositionFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ConversionOptimizerAdGroupCriterionBids : AdGroupCriterionBids {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BudgetOptimizerAdGroupCriterionBids : AdGroupCriterionBids {
    private Bid proxyBidField;

    public Bid proxyBid {
      get {
        return this.proxyBidField;
      }
      set {
        this.proxyBidField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class QualityInfo {
    private bool isKeywordAdRelevanceAcceptableField;

    private bool isKeywordAdRelevanceAcceptableFieldSpecified;

    private bool isLandingPageQualityAcceptableField;

    private bool isLandingPageQualityAcceptableFieldSpecified;

    private bool isLandingPageLatencyAcceptableField;

    private bool isLandingPageLatencyAcceptableFieldSpecified;

    private int qualityScoreField;

    private bool qualityScoreFieldSpecified;

    public bool isKeywordAdRelevanceAcceptable {
      get {
        return this.isKeywordAdRelevanceAcceptableField;
      }
      set {
        this.isKeywordAdRelevanceAcceptableField = value;
        this.isKeywordAdRelevanceAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isKeywordAdRelevanceAcceptableSpecified {
      get {
        return this.isKeywordAdRelevanceAcceptableFieldSpecified;
      }
      set {
        this.isKeywordAdRelevanceAcceptableFieldSpecified = value;
      }
    }

    public bool isLandingPageQualityAcceptable {
      get {
        return this.isLandingPageQualityAcceptableField;
      }
      set {
        this.isLandingPageQualityAcceptableField = value;
        this.isLandingPageQualityAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isLandingPageQualityAcceptableSpecified {
      get {
        return this.isLandingPageQualityAcceptableFieldSpecified;
      }
      set {
        this.isLandingPageQualityAcceptableFieldSpecified = value;
      }
    }

    public bool isLandingPageLatencyAcceptable {
      get {
        return this.isLandingPageLatencyAcceptableField;
      }
      set {
        this.isLandingPageLatencyAcceptableField = value;
        this.isLandingPageLatencyAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isLandingPageLatencyAcceptableSpecified {
      get {
        return this.isLandingPageLatencyAcceptableFieldSpecified;
      }
      set {
        this.isLandingPageLatencyAcceptableFieldSpecified = value;
      }
    }

    public int qualityScore {
      get {
        return this.qualityScoreField;
      }
      set {
        this.qualityScoreField = value;
        this.qualityScoreSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool qualityScoreSpecified {
      get {
        return this.qualityScoreFieldSpecified;
      }
      set {
        this.qualityScoreFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Campaign {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private CampaignStatus statusField;

    private bool statusFieldSpecified;

    private ServingStatus servingStatusField;

    private bool servingStatusFieldSpecified;

    private string startDateField;

    private string endDateField;

    private Budget budgetField;

    private BiddingStrategy biddingStrategyField;

    private AutoKeywordMatchingStatus autoKeywordMatchingStatusField;

    private bool autoKeywordMatchingStatusFieldSpecified;

    private Stats statsField;

    private AdServingOptimizationStatus adServingOptimizationStatusField;

    private bool adServingOptimizationStatusFieldSpecified;

    private FrequencyCap frequencyCapField;

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

    public CampaignStatus status {
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

    public ServingStatus servingStatus {
      get {
        return this.servingStatusField;
      }
      set {
        this.servingStatusField = value;
        this.servingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool servingStatusSpecified {
      get {
        return this.servingStatusFieldSpecified;
      }
      set {
        this.servingStatusFieldSpecified = value;
      }
    }

    public string startDate {
      get {
        return this.startDateField;
      }
      set {
        this.startDateField = value;
      }
    }

    public string endDate {
      get {
        return this.endDateField;
      }
      set {
        this.endDateField = value;
      }
    }

    public Budget budget {
      get {
        return this.budgetField;
      }
      set {
        this.budgetField = value;
      }
    }

    public BiddingStrategy biddingStrategy {
      get {
        return this.biddingStrategyField;
      }
      set {
        this.biddingStrategyField = value;
      }
    }

    public AutoKeywordMatchingStatus autoKeywordMatchingStatus {
      get {
        return this.autoKeywordMatchingStatusField;
      }
      set {
        this.autoKeywordMatchingStatusField = value;
        this.autoKeywordMatchingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool autoKeywordMatchingStatusSpecified {
      get {
        return this.autoKeywordMatchingStatusFieldSpecified;
      }
      set {
        this.autoKeywordMatchingStatusFieldSpecified = value;
      }
    }

    public Stats stats {
      get {
        return this.statsField;
      }
      set {
        this.statsField = value;
      }
    }

    public AdServingOptimizationStatus adServingOptimizationStatus {
      get {
        return this.adServingOptimizationStatusField;
      }
      set {
        this.adServingOptimizationStatusField = value;
        this.adServingOptimizationStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adServingOptimizationStatusSpecified {
      get {
        return this.adServingOptimizationStatusFieldSpecified;
      }
      set {
        this.adServingOptimizationStatusFieldSpecified = value;
      }
    }

    public FrequencyCap frequencyCap {
      get {
        return this.frequencyCapField;
      }
      set {
        this.frequencyCapField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CampaignStatus {
    ACTIVE,
    DELETED,
    PAUSED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum ServingStatus {
    SERVING,
    NONE,
    ENDED,
    PENDING,
    SUSPENDED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class Budget {
    private BudgetBudgetPeriod periodField;

    private bool periodFieldSpecified;

    private Money amountField;

    private BudgetBudgetDeliveryMethod deliveryMethodField;

    private bool deliveryMethodFieldSpecified;

    public BudgetBudgetPeriod period {
      get {
        return this.periodField;
      }
      set {
        this.periodField = value;
        this.periodSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool periodSpecified {
      get {
        return this.periodFieldSpecified;
      }
      set {
        this.periodFieldSpecified = value;
      }
    }

    public Money amount {
      get {
        return this.amountField;
      }
      set {
        this.amountField = value;
      }
    }

    public BudgetBudgetDeliveryMethod deliveryMethod {
      get {
        return this.deliveryMethodField;
      }
      set {
        this.deliveryMethodField = value;
        this.deliveryMethodSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deliveryMethodSpecified {
      get {
        return this.deliveryMethodFieldSpecified;
      }
      set {
        this.deliveryMethodFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Budget.BudgetPeriod", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BudgetBudgetPeriod {
    DAILY,
    MONTHLY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Budget.BudgetDeliveryMethod", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BudgetBudgetDeliveryMethod {
    STANDARD,
    ACCELERATED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPM))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPC))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizer))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizer))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class BiddingStrategy {
    private string biddingStrategyTypeField;

    [System.Xml.Serialization.XmlElementAttribute("BiddingStrategy.Type")]
    public string BiddingStrategyType {
      get {
        return this.biddingStrategyTypeField;
      }
      set {
        this.biddingStrategyTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ManualCPM : BiddingStrategy {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ManualCPC : BiddingStrategy {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ConversionOptimizer : BiddingStrategy {
    private PricingModel pricingModelField;

    private bool pricingModelFieldSpecified;

    public PricingModel pricingModel {
      get {
        return this.pricingModelField;
      }
      set {
        this.pricingModelField = value;
        this.pricingModelSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool pricingModelSpecified {
      get {
        return this.pricingModelFieldSpecified;
      }
      set {
        this.pricingModelFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum PricingModel {
    CLICKS,
    IMPRESSIONS,
    CONVERSIONS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BudgetOptimizer : BiddingStrategy {
    private Money bidCeilingField;

    public Money bidCeiling {
      get {
        return this.bidCeilingField;
      }
      set {
        this.bidCeilingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AutoKeywordMatchingStatus {
    OPT_IN,
    OPT_OUT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdServingOptimizationStatus {
    OPTIMIZE,
    ROTATE,
    UNAVAILABLE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class FrequencyCap {
    private long impressionsField;

    private bool impressionsFieldSpecified;

    private TimeUnit timeUnitField;

    private bool timeUnitFieldSpecified;

    private Level levelField;

    private bool levelFieldSpecified;

    public long impressions {
      get {
        return this.impressionsField;
      }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get {
        return this.impressionsFieldSpecified;
      }
      set {
        this.impressionsFieldSpecified = value;
      }
    }

    public TimeUnit timeUnit {
      get {
        return this.timeUnitField;
      }
      set {
        this.timeUnitField = value;
        this.timeUnitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool timeUnitSpecified {
      get {
        return this.timeUnitFieldSpecified;
      }
      set {
        this.timeUnitFieldSpecified = value;
      }
    }

    public Level level {
      get {
        return this.levelField;
      }
      set {
        this.levelField = value;
        this.levelSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool levelSpecified {
      get {
        return this.levelFieldSpecified;
      }
      set {
        this.levelFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum TimeUnit {
    MINUTE,
    HOUR,
    DAY,
    WEEK,
    MONTH,
    LIFETIME
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum Level {
    CREATIVE,
    ADGROUP
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeCampaignCriterion))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterion {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private Criterion criterionField;

    private string campaignCriterionTypeField;

    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    public Criterion criterion {
      get {
        return this.criterionField;
      }
      set {
        this.criterionField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterion.Type")]
    public string CampaignCriterionType {
      get {
        return this.campaignCriterionTypeField;
      }
      set {
        this.campaignCriterionTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NegativeCampaignCriterion : CampaignCriterion {
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJob))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class Job {
    private string customerJobKeyField;

    private JobContext contextField;

    private ApiErrorReason failureReasonField;

    private JobStats statsField;

    private BillingSummary billingSummaryField;

    private string jobTypeField;

    public string customerJobKey {
      get {
        return this.customerJobKeyField;
      }
      set {
        this.customerJobKeyField = value;
      }
    }

    public JobContext context {
      get {
        return this.contextField;
      }
      set {
        this.contextField = value;
      }
    }

    public ApiErrorReason failureReason {
      get {
        return this.failureReasonField;
      }
      set {
        this.failureReasonField = value;
      }
    }

    public JobStats stats {
      get {
        return this.statsField;
      }
      set {
        this.statsField = value;
      }
    }

    public BillingSummary billingSummary {
      get {
        return this.billingSummaryField;
      }
      set {
        this.billingSummaryField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Job.Type")]
    public string JobType {
      get {
        return this.jobTypeField;
      }
      set {
        this.jobTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class JobContext {
    private string authenticatedUserEmailField;

    private long effectiveCustomerIdField;

    private bool effectiveCustomerIdFieldSpecified;

    public string authenticatedUserEmail {
      get {
        return this.authenticatedUserEmailField;
      }
      set {
        this.authenticatedUserEmailField = value;
      }
    }

    public long effectiveCustomerId {
      get {
        return this.effectiveCustomerIdField;
      }
      set {
        this.effectiveCustomerIdField = value;
        this.effectiveCustomerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool effectiveCustomerIdSpecified {
      get {
        return this.effectiveCustomerIdFieldSpecified;
      }
      set {
        this.effectiveCustomerIdFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ApiErrorReason {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("AdErrorReason", typeof(AdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupAdErrorReason", typeof(AdGroupAdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionErrorReason", typeof(AdGroupCriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupServiceErrorReason", typeof(AdGroupServiceErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AuthenticationErrorReason", typeof(AuthenticationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AuthorizationErrorReason", typeof(AuthorizationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BiddingErrorReason", typeof(BiddingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BiddingTransitionErrorReason", typeof(BiddingTransitionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BudgetErrorReason", typeof(BudgetErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BulkMutateJobErrorReason", typeof(BulkMutateJobErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterionErrorReason", typeof(CampaignCriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignErrorReason", typeof(CampaignErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ClientTermsErrorReason", typeof(ClientTermsErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DatabaseErrorReason", typeof(DatabaseErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DateErrorReason", typeof(DateErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DistinctErrorReason", typeof(DistinctErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityAccessDeniedReason", typeof(EntityAccessDeniedReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityCountLimitExceededReason", typeof(EntityCountLimitExceededReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityNotFoundReason", typeof(EntityNotFoundReason))]
    [System.Xml.Serialization.XmlElementAttribute("IdErrorReason", typeof(IdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ImageErrorReason", typeof(ImageErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("InternalApiErrorReason", typeof(InternalApiErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("JobErrorReason", typeof(JobErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("LoasAuthenticationErrorReason", typeof(LoasAuthenticationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("MediaErrorReason", typeof(MediaErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NewEntityCreationErrorReason", typeof(NewEntityCreationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NotEmptyErrorReason", typeof(NotEmptyErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NotWhitelistedErrorReason", typeof(NotWhitelistedErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NullErrorReason", typeof(NullErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("OperationAccessDeniedReason", typeof(OperationAccessDeniedReason))]
    [System.Xml.Serialization.XmlElementAttribute("OperatorErrorReason", typeof(OperatorErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("PagingErrorReason", typeof(PagingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("PolicyViolationErrorReason", typeof(PolicyViolationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaCheckErrorReason", typeof(QuotaCheckErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaErrorReason", typeof(QuotaErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaExceededErrorReason", typeof(QuotaExceededErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RangeErrorReason", typeof(RangeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ReadOnlyErrorReason", typeof(ReadOnlyErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RegionCodeErrorReason", typeof(RegionCodeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RequestErrorReason", typeof(RequestErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RequiredErrorReason", typeof(RequiredErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("SizeLimitErrorReason", typeof(SizeLimitErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("StatsQueryErrorReason", typeof(StatsQueryErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("StringLengthErrorReason", typeof(StringLengthErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("TargetErrorReason", typeof(TargetErrorReason))]
    public object Item {
      get {
        return this.itemField;
      }
      set {
        this.itemField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdErrorReason {
    APPROXIMATELY_TOO_LONG,
    APPROXIMATELY_TOO_SHORT,
    CANNOT_SET_BUSINESS_NAME_IF_URL_SET,
    CUSTOMER_NOT_APPROVED_MOBILEADS,
    CUSTOMER_NOT_APPROVED_THIRDPARTY_ADS,
    CUSTOMER_NOT_APPROVED_THIRDPARTY_REDIRECT_ADS,
    CUSTOMER_NOT_ELIGIBLE_FOR_UPDATING_BEACON_URL,
    DIMENSION_ALREADY_IN_UNION,
    DIMENSION_MUST_BE_SET,
    DIMENSION_NOT_IN_UNION,
    DOMESTIC_PHONE_NUMBER_FORMAT,
    EMERGENCY_PHONE_NUMBER,
    EMPTY_FIELD,
    INCONSISTENT_STATUS_IN_TEMPLATE_UNION,
    INCORRECT_LENGTH,
    INVALID_AD_ADDRESS_CAMPAIGN_TARGET,
    INVALID_AD_TYPE,
    INVALID_ATTRIBUTES_FOR_MOBILE_IMAGE,
    INVALID_ATTRIBUTES_FOR_MOBILE_TEXT,
    INVALID_COUNTRY_CODE,
    INVALID_INPUT,
    INVALID_MARKUP_LANGUAGE,
    INVALID_MOBILE_CARRIER,
    INVALID_MOBILE_CARRIER_TARGET,
    INVALID_NUMBER_OF_ELEMENTS,
    INVALID_PHONE_NUMBER_FORMAT,
    INVALID_TEMPLATE_DATA,
    INVALID_TEMPLATE_ELEMENT_FIELD_TYPE,
    INVALID_TEMPLATE_ID,
    LINE_TOO_WIDE,
    MARKUP_LANGUAGES_PRESENT,
    MISSING_ADDRESS_COMPONENT,
    MISSING_ADVERTISEMENT_NAME,
    MISSING_BUSINESS_NAME,
    MISSING_DESCRIPTION1,
    MISSING_DESCRIPTION2,
    MISSING_DESTINATION_URL,
    MISSING_DIMENSION,
    MISSING_DISPLAY_URL,
    MISSING_HEADLINE,
    MISSING_HEIGHT,
    MISSING_IMAGE,
    MISSING_MARKUP_LANGUAGES,
    MISSING_MOBILE_CARRIER,
    MISSING_PHONE,
    MISSING_REQUIRED_TEMPLATE_FIELDS,
    MISSING_TEMPLATE_FIELD_VALUE,
    MISSING_TEXT,
    MISSING_URL_AND_PHONE,
    MISSING_VISIBLE_URL,
    MISSING_WIDTH,
    MUST_USE_TEMP_AD_UNION_ID_ON_ADD,
    TOO_LONG,
    TOO_SHORT,
    UNION_DIMENSIONS_CANNOT_CHANGE,
    UNKNOWN_ADDRESS_COMPONENT,
    UNKNOWN_FIELD_NAME,
    UNKNOWN_UNIQUE_NAME,
    UNSUPPORTED_DIMENSIONS,
    URL_INVALID_TOP_LEVEL_DOMAIN,
    URL_MALFORMED,
    URL_NO_HOST,
    URL_NO_SCHEME,
    URL_NO_TOP_LEVEL_DOMAIN,
    URL_PATH_NOT_ALLOWED,
    URL_PORT_NOT_ALLOWED,
    URL_QUERY_NOT_ALLOWED,
    USER_DOES_NOT_HAVE_ACCESS_TO_TEMPLATE,
    INVALID_FORMAT,
    ELEMENT_NOT_PRESENT,
    IMAGE_ERROR,
    VALUE_NOT_IN_RANGE,
    FIELD_NOT_PRESENT,
    ADDRESS_NOT_COMPLETE,
    ADDRESS_INVALID,
    VIDEO_RETRIEVAL_ERROR,
    AUDIO_ERROR,
    INVALID_YOUTUBE_DISPLAY_URL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupAdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdGroupAdErrorReason {
    AD_NOT_UNDER_ADGROUP,
    CANNOT_OPERATE_ON_DELETED_ADGROUPAD,
    CANNOT_CREATE_DEPRECATED_ADS,
    EMPTY_FIELD,
    ENTITY_REFERENCED_IN_MULTIPLE_OPS,
    UNSUPPORTED_OPERATION
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdGroupServiceErrorReason {
    ADGROUP_CAMPAIGN_MISMATCH,
    DUPLICATE_ADGROUP_NAME,
    INVALID_ADGROUP_ID,
    INVALID_ADGROUP_NAME,
    USE_SET_OPERATOR_AND_MARK_STATUS_TO_DELETED,
    ADVERTISER_NOT_ON_CONTENT_NETWORK,
    BID_EXCEEDS_AUTO_BUDGET,
    BID_EXCEEDS_CUSTOM_BUDGET,
    BID_EXCEEDS_DAILY_BUDGET,
    BID_EXCEEDS_MONTHLY_BUDGET,
    BID_TOO_BIG,
    BID_TOO_SMALL,
    BID_TYPE_AND_BIDDING_STRATEGY_MISMATCH,
    BIDS_NOT_REQUIRED,
    ILLEGAL_MANUAL_BID,
    INCOMPATIBLE_WITH_KEYWORD_AND_SITE_VBB,
    INCOMPATIBLE_WITH_KEYWORD_CPC,
    INCOMPATIBLE_WITH_KEYWORD_CPC_AND_SITE_CPC,
    INCOMPATIBLE_WITH_KEYWORD_CPM,
    INCOMPATIBLE_WITH_KEYWORD_CPM_AND_SITE_CPM,
    INCOMPATIBLE_WITH_SITE_CPC,
    INCOMPATIBLE_WITH_SITE_CPM,
    INCOMPATIBLE_WITH_VBB,
    INCOMPATIBLE_WITH_SITE_VBB,
    INVALID_BID,
    MISSING_ADGROUP_NAME,
    MISSING_BID,
    MULTIPLE_BID_TYPES,
    NO_CAMPAIGN_BUDGET,
    NOT_WHITELISTED_FOR_SITE_CPC,
    SEPARATE_CONTENT_BIDS_INAPPLICABLE,
    SEPARATE_CONTENT_BIDS_NOT_ENABLED,
    TOO_MANY_FRACTION_DIGITS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingTransitionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BiddingTransitionErrorReason {
    BID_TO_POSITION_ENABLED,
    BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    BUDGET_OPTIMIZER_IS_ENABLED,
    CONVERSION_OPTIMIZER_IS_ENABLED,
    CONVERSION_TRACKING_NOT_ENABLED,
    CONVERSION_TRACKING_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    USE_POSITION_PREFERENCE_IN_MANUALCPC_INSTEAD_TO_DISABLE_POSITION_PREFERENCE,
    INVALID_BID,
    CANNOT_SET_EXPLICIT_BID,
    EXPLICIT_BID_REQUIRED_FOR_TRANSITION,
    EXPLICIT_BID_TYPE_DOES_NOT_MATCH_CAMPAIGN_BIDDING_STRATEGY,
    MISSING_REQUIRED_BID,
    INVALID_STATUS,
    IS_CPM_CAMPAIGN,
    NOT_THE_PREVIOUS_BIDDING_STRATEGY,
    NOT_ENOUGH_CONVERSION_DATA,
    NOT_ENOUGH_CONVERSIONS,
    OPTED_IN_SEARCH,
    PROXY_BIDDING_ON,
    SITE_REMNANT_RESERVATION_ALLOWED,
    TRANSITION_TO_ITSELF,
    UNKNOWN_BIDDING_STRATEGY,
    UNSUPPORTED_TRANSITION,
    VCG_ENABLED,
    BIDDING_TRANSITION_FAILED,
    ACCELERATED_DELIVERY_NOT_SUPPORTED_FOR_BUDGET_OPTIMIZER
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BulkMutateJobError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BulkMutateJobErrorReason {
    CAN_RETURN_RESULT_FOR_ONLY_COMPLETED_JOBS,
    CAN_RETURN_RESULT_FOR_ONLY_ONE_JOB,
    CANNOT_UPDATE_JOB_ONCE_ALL_REQUEST_PARTS_ARE_RECEIVED,
    INVALID_SCOPING_ENTITY_TYPE,
    MISSING_SCOPING_ENTITY_FOR_OPERATION_STREAM,
    MORE_THAN_ONE_SCOPING_ENTITY_TYPE,
    PAYLOAD_STORE_UNAVAILABLE,
    REQUEST_PART_IS_OUT_OF_ORDER,
    TOO_MANY_OPERATION_STREAMS_IN_REQUEST_PART,
    TOO_MANY_OPERATIONS_IN_JOB,
    TOO_MANY_OPERATIONS_IN_REQUEST_PART,
    TOO_MANY_RESULTS_TO_STORE,
    TOO_MANY_SCOPING_ENTITIES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignCriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CampaignCriterionErrorReason {
    CRITERIA_QUOTA_EXCEEDED,
    CONCRETE_TYPE_REQUIRED,
    ID_FILTERS_HAVE_DIFF_FIELDS_SET,
    INVALID_EXCLUDED_CATEGORY,
    INVALID_KEYWORD_TEXT,
    INVALID_PLACEMENT_URL,
    TOO_MANY_OPERTAIONS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CampaignErrorReason {
    AFTER_MAXIMUM_ALLOWABLE_DATE,
    CANNOT_GO_BACK_TO_INCOMPLETE,
    CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED,
    CANNOT_SET_ACCELERATED_DELIVERY_FOR_BUDGET_OPTIMIZER_CAMPAIGN,
    CANNOT_SET_DATE_TO_PAST,
    CANNOT_SET_POSITION_PREFERENCE_IF_NOT_SEARCH_TARGETED,
    CURRENCY_NOT_VALID_FOR_ACCOUNT,
    DUPLICATE_CAMPAIGN_NAME,
    INCOMPATIBLE_CAMPAIGN_FIELD,
    INVALID_CAMPAIGN_NAME,
    INVALID_AD_SERVING_OPTIMIZATION_STATUS,
    KEYWORD_QUOTA_EXCEEDED,
    MAX_IMPRESSIONS_NOT_IN_RANGE,
    START_DATE_AFTER_END_DATE,
    TIME_UNIT_NOT_SUPPORTED,
    USE_BIDDING_TRANSITION_FIELD_INSTEAD_TO_SWITCH_BIDDING_STRATEGY,
    CANNOT_CHANGE_CAMPAIGN_TYPE,
    INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED,
    CANNOT_CHANGE_TV_CAMPAIGN,
    CANNOT_ADD_CAMPAIGN_WITH_CONVERSION_OPTIMIZER_BIDDING_STRATEGY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityAccessDenied.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum EntityAccessDeniedReason {
    READ_ACCESS_DENIED,
    WRITE_ACCESS_DENIED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum IdErrorReason {
    NOT_FOUND
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ImageError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum ImageErrorReason {
    INVALID_IMAGE,
    STORAGE_ERROR,
    BAD_REQUEST,
    UNEXPECTED_SIZE,
    ANIMATED_NOT_ALLOWED,
    ANIMATION_TOO_LONG,
    SERVER_ERROR,
    CMYK_JPEG_NOT_ALLOWED,
    FLASH_NOT_ALLOWED,
    FLASH_WITHOUT_CLICKTAG,
    ANIMATED_VISUAL_EFFECT,
    FLASH_ERROR,
    LAYOUT_PROBLEM,
    PROBLEM_READING_IMAGE_FILE,
    ERROR_STORING_IMAGE,
    FLASH_HAS_NETWORK_OBJECTS,
    FLASH_HAS_NETWORK_METHODS,
    FLASH_HAS_URL,
    FLASH_HAS_MOUSE_TRACKING,
    FLASH_HAS_RANDOM_NUM,
    FLASH_SELF_TARGETS,
    FLASH_BAD_GETURL_TARGET,
    FLASH_VERSION_NOT_SUPPORTED,
    FILE_TOO_LARGE,
    IMAGE_DATA_TOO_LARGE,
    IMAGE_PROCESSING_ERROR,
    IMAGE_TOO_SMALL,
    INVALID_INPUT,
    PROBLEM_READING_FILE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "JobError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum JobErrorReason {
    DUPLICATE_JOB_KEY_FOR_CUSTOMER,
    JOB_TYPE_NOT_SUPPORTED,
    PREREQUISITE_JOB_FAILED,
    SELECTOR_CANNOT_USE_BOTH_JOB_IDS_AND_JOB_KEYS,
    TOO_MANY_PREREQUISITE_JOBS,
    TOO_MANY_JOBS_IN_QUEUE,
    WORKFLOW_FAILURE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LoasAuthenticationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum LoasAuthenticationErrorReason {
    PROTOCOL_MISMATCH,
    SECURITY_LEVEL_MISMATCH,
    CLIENT_NOT_AUTHORIZED,
    ADS_USER_NOT_FOUND,
    NOT_INTERNAL_USER
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MediaError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum MediaErrorReason {
    CANNOT_ADD_STANDARD_ICON,
    DUPLICATE_MEDIA,
    EMPTY_FIELD,
    ENTITY_REFERENCED_IN_MULTIPLE_OPS,
    FIELD_NOT_SUPPORTED_FOR_MEDIA_SUB_TYPE,
    INVALID_MEDIA_ID,
    INVALID_MEDIA_TYPE,
    INVALID_MEDIA_SUB_TYPE,
    INVALID_REFERENCE_ID,
    MEDIA_FAILED_TRANSCODING,
    MEDIA_TYPE_DOES_NOT_MATCH_OBJECT_TYPE,
    NO_FIELDS_SPECIFIED,
    NULL_REFERENCE_ID_AND_MEDIA_ID,
    TOO_LONG,
    UNSUPPORTED_OPERATION,
    UNSUPPORTED_TYPE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NewEntityCreationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum NewEntityCreationErrorReason {
    CANNOT_SET_ID_FOR_ADD
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OperationAccessDenied.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum OperationAccessDeniedReason {
    ACTION_NOT_PERMITTED,
    ADD_OPERATION_NOT_PERMITTED,
    REMOVE_OPERATION_NOT_PERMITTED,
    SET_OPERATION_NOT_PERMITTED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PagingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum PagingErrorReason {
    START_INDEX_CANNOT_BE_NEGATIVE,
    NUMBER_OF_RESULTS_CANNOT_BE_NEGATIVE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PolicyViolationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum PolicyViolationErrorReason {
    POLICY_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum QuotaErrorReason {
    TOO_MANY_ADGROUPS_PER_CAMPAIGN,
    TOO_MANY_CAMPAIGNS_PER_ACCOUNT,
    TOO_MANY_CONVERSION_TYPES_PER_ACCOUNT,
    TOO_MANY_KEYWORDS_PER_ADGROUP,
    TOO_MANY_KEYWORDS_PER_CAMPAIGN,
    TOO_MANY_KEYWORDS_PER_CUSTOMER,
    TOO_MANY_SITES_PER_ADGROUP,
    TOO_MANY_SITES_PER_CAMPAIGN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RequestError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum RequestErrorReason {
    UNKNOWN,
    INVALID_INPUT
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobStats))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class JobStats {
    private int progressPercentField;

    private bool progressPercentFieldSpecified;

    private long pendingTimeMillisField;

    private bool pendingTimeMillisFieldSpecified;

    private long processingTimeMillisField;

    private bool processingTimeMillisFieldSpecified;

    private string jobStatsTypeField;

    public int progressPercent {
      get {
        return this.progressPercentField;
      }
      set {
        this.progressPercentField = value;
        this.progressPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool progressPercentSpecified {
      get {
        return this.progressPercentFieldSpecified;
      }
      set {
        this.progressPercentFieldSpecified = value;
      }
    }

    public long pendingTimeMillis {
      get {
        return this.pendingTimeMillisField;
      }
      set {
        this.pendingTimeMillisField = value;
        this.pendingTimeMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool pendingTimeMillisSpecified {
      get {
        return this.pendingTimeMillisFieldSpecified;
      }
      set {
        this.pendingTimeMillisFieldSpecified = value;
      }
    }

    public long processingTimeMillis {
      get {
        return this.processingTimeMillisField;
      }
      set {
        this.processingTimeMillisField = value;
        this.processingTimeMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool processingTimeMillisSpecified {
      get {
        return this.processingTimeMillisFieldSpecified;
      }
      set {
        this.processingTimeMillisFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobStats.Type")]
    public string JobStatsType {
      get {
        return this.jobStatsTypeField;
      }
      set {
        this.jobStatsTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateJobStats : JobStats {
    private int numOperationsField;

    private bool numOperationsFieldSpecified;

    private int numFailedOperationsField;

    private bool numFailedOperationsFieldSpecified;

    private int numUnprocessedOperationsField;

    private bool numUnprocessedOperationsFieldSpecified;

    public int numOperations {
      get {
        return this.numOperationsField;
      }
      set {
        this.numOperationsField = value;
        this.numOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numOperationsSpecified {
      get {
        return this.numOperationsFieldSpecified;
      }
      set {
        this.numOperationsFieldSpecified = value;
      }
    }

    public int numFailedOperations {
      get {
        return this.numFailedOperationsField;
      }
      set {
        this.numFailedOperationsField = value;
        this.numFailedOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numFailedOperationsSpecified {
      get {
        return this.numFailedOperationsFieldSpecified;
      }
      set {
        this.numFailedOperationsFieldSpecified = value;
      }
    }

    public int numUnprocessedOperations {
      get {
        return this.numUnprocessedOperationsField;
      }
      set {
        this.numUnprocessedOperationsField = value;
        this.numUnprocessedOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numUnprocessedOperationsSpecified {
      get {
        return this.numUnprocessedOperationsFieldSpecified;
      }
      set {
        this.numUnprocessedOperationsFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BillingSummary {
    private int numOperationsField;

    private bool numOperationsFieldSpecified;

    private long numUnitsField;

    private bool numUnitsFieldSpecified;

    public int numOperations {
      get {
        return this.numOperationsField;
      }
      set {
        this.numOperationsField = value;
        this.numOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numOperationsSpecified {
      get {
        return this.numOperationsFieldSpecified;
      }
      set {
        this.numOperationsFieldSpecified = value;
      }
    }

    public long numUnits {
      get {
        return this.numUnitsField;
      }
      set {
        this.numUnitsField = value;
        this.numUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numUnitsSpecified {
      get {
        return this.numUnitsFieldSpecified;
      }
      set {
        this.numUnitsFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateJob : Job {
    private long idField;

    private bool idFieldSpecified;

    private BulkMutateJobPolicy policyField;

    private BulkMutateRequest requestField;

    private BasicJobStatus statusField;

    private bool statusFieldSpecified;

    private BulkMutateJobEvent[] historyField;

    private BulkMutateResult resultField;

    private int numRequestPartsField;

    private bool numRequestPartsFieldSpecified;

    private int numRequestPartsReceivedField;

    private bool numRequestPartsReceivedFieldSpecified;

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

    public BulkMutateJobPolicy policy {
      get {
        return this.policyField;
      }
      set {
        this.policyField = value;
      }
    }

    public BulkMutateRequest request {
      get {
        return this.requestField;
      }
      set {
        this.requestField = value;
      }
    }

    public BasicJobStatus status {
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

    [System.Xml.Serialization.XmlElementAttribute("history")]
    public BulkMutateJobEvent[] history {
      get {
        return this.historyField;
      }
      set {
        this.historyField = value;
      }
    }

    public BulkMutateResult result {
      get {
        return this.resultField;
      }
      set {
        this.resultField = value;
      }
    }

    public int numRequestParts {
      get {
        return this.numRequestPartsField;
      }
      set {
        this.numRequestPartsField = value;
        this.numRequestPartsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numRequestPartsSpecified {
      get {
        return this.numRequestPartsFieldSpecified;
      }
      set {
        this.numRequestPartsFieldSpecified = value;
      }
    }

    public int numRequestPartsReceived {
      get {
        return this.numRequestPartsReceivedField;
      }
      set {
        this.numRequestPartsReceivedField = value;
        this.numRequestPartsReceivedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numRequestPartsReceivedSpecified {
      get {
        return this.numRequestPartsReceivedFieldSpecified;
      }
      set {
        this.numRequestPartsReceivedFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateJobPolicy {
    private long[] prerequisiteJobIdsField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("prerequisiteJobIds")]
    public long[] prerequisiteJobIds {
      get {
        return this.prerequisiteJobIdsField;
      }
      set {
        this.prerequisiteJobIdsField = value;
      }
    }

    public string dummy {
      get {
        return this.dummyField;
      }
      set {
        this.dummyField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateRequest {
    private int partIndexField;

    private bool partIndexFieldSpecified;

    private OperationStream[] operationStreamsField;

    public int partIndex {
      get {
        return this.partIndexField;
      }
      set {
        this.partIndexField = value;
        this.partIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool partIndexSpecified {
      get {
        return this.partIndexFieldSpecified;
      }
      set {
        this.partIndexFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("operationStreams")]
    public OperationStream[] operationStreams {
      get {
        return this.operationStreamsField;
      }
      set {
        this.operationStreamsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class OperationStream {
    private EntityId scopingEntityIdField;

    private Operation[] operationsField;

    public EntityId scopingEntityId {
      get {
        return this.scopingEntityIdField;
      }
      set {
        this.scopingEntityIdField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("operations")]
    public Operation[] operations {
      get {
        return this.operationsField;
      }
      set {
        this.operationsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class EntityId {
    private EntityIdType typeField;

    private bool typeFieldSpecified;

    private long valueField;

    private bool valueFieldSpecified;

    public EntityIdType type {
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

    public long value {
      get {
        return this.valueField;
      }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get {
        return this.valueFieldSpecified;
      }
      set {
        this.valueFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityId.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum EntityIdType {
    ADGROUP_ID,
    AD_ID,
    CAMPAIGN_ID,
    CUSTOMER_ID
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class JobOperation : Operation {
    private Job operandField;

    public Job operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignTargetOperation : Operation {
    private TargetList operandField;

    public TargetList operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlatformTargetList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkTargetList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageTargetList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoTargetList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DemographicTargetList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdScheduleTargetList))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class TargetList {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string targetListTypeField;

    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("TargetList.Type")]
    public string TargetListType {
      get {
        return this.targetListTypeField;
      }
      set {
        this.targetListTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class PlatformTargetList : TargetList {
    private PlatformTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public PlatformTarget[] targets {
      get {
        return this.targetsField;
      }
      set {
        this.targetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NetworkTargetList : TargetList {
    private NetworkTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public NetworkTarget[] targets {
      get {
        return this.targetsField;
      }
      set {
        this.targetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class LanguageTargetList : TargetList {
    private LanguageTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public LanguageTarget[] targets {
      get {
        return this.targetsField;
      }
      set {
        this.targetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class GeoTargetList : TargetList {
    private GeoTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public GeoTarget[] targets {
      get {
        return this.targetsField;
      }
      set {
        this.targetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class DemographicTargetList : TargetList {
    private DemographicTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public DemographicTarget[] targets {
      get {
        return this.targetsField;
      }
      set {
        this.targetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdScheduleTargetList : TargetList {
    private AdScheduleTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public AdScheduleTarget[] targets {
      get {
        return this.targetsField;
      }
      set {
        this.targetsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignOperation : Operation {
    private BiddingTransition biddingTransitionField;

    private Campaign operandField;

    public BiddingTransition biddingTransition {
      get {
        return this.biddingTransitionField;
      }
      set {
        this.biddingTransitionField = value;
      }
    }

    public Campaign operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerBiddingTransition))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BiddingTransition {
    private BiddingStrategy targetBiddingStrategyField;

    private AdGroupBids explicitAdGroupBidsField;

    private string biddingTransitionTypeField;

    public BiddingStrategy targetBiddingStrategy {
      get {
        return this.targetBiddingStrategyField;
      }
      set {
        this.targetBiddingStrategyField = value;
      }
    }

    public AdGroupBids explicitAdGroupBids {
      get {
        return this.explicitAdGroupBidsField;
      }
      set {
        this.explicitAdGroupBidsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("BiddingTransition.Type")]
    public string BiddingTransitionType {
      get {
        return this.biddingTransitionTypeField;
      }
      set {
        this.biddingTransitionTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ConversionOptimizerBiddingTransition : BiddingTransition {
    private bool useSavedBidsField;

    private bool useSavedBidsFieldSpecified;

    public bool useSavedBids {
      get {
        return this.useSavedBidsField;
      }
      set {
        this.useSavedBidsField = value;
        this.useSavedBidsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool useSavedBidsSpecified {
      get {
        return this.useSavedBidsFieldSpecified;
      }
      set {
        this.useSavedBidsFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterionOperation : Operation {
    private CampaignCriterion operandField;

    public CampaignCriterion operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupOperation : Operation {
    private AdGroup operandField;

    public AdGroup operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterionOperation : Operation {
    private AdGroupCriterion operandField;

    private ExemptionRequest[] exemptionRequestsField;

    public AdGroupCriterion operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("exemptionRequests")]
    public ExemptionRequest[] exemptionRequests {
      get {
        return this.exemptionRequestsField;
      }
      set {
        this.exemptionRequestsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ExemptionRequest {
    private PolicyViolationKey keyField;

    public PolicyViolationKey key {
      get {
        return this.keyField;
      }
      set {
        this.keyField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupAdOperation : Operation {
    private AdGroupAd operandField;

    private ExemptionRequest[] exemptionRequestsField;

    public AdGroupAd operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("exemptionRequests")]
    public ExemptionRequest[] exemptionRequests {
      get {
        return this.exemptionRequestsField;
      }
      set {
        this.exemptionRequestsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum BasicJobStatus {
    COMPLETED,
    PROCESSING,
    FAILED,
    PENDING
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateJobEvent : JobEvent {
    private BasicJobStatus statusField;

    private bool statusFieldSpecified;

    public BasicJobStatus status {
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

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobEvent))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class JobEvent {
    private string dateTimeField;

    private string jobEventTypeField;

    public string dateTime {
      get {
        return this.dateTimeField;
      }
      set {
        this.dateTimeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobEvent.Type")]
    public string JobEventType {
      get {
        return this.jobEventTypeField;
      }
      set {
        this.jobEventTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateResult {
    private int partIndexField;

    private bool partIndexFieldSpecified;

    private OperationStreamResult[] operationStreamResultsField;

    public int partIndex {
      get {
        return this.partIndexField;
      }
      set {
        this.partIndexField = value;
        this.partIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool partIndexSpecified {
      get {
        return this.partIndexFieldSpecified;
      }
      set {
        this.partIndexFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("operationStreamResults")]
    public OperationStreamResult[] operationStreamResults {
      get {
        return this.operationStreamResultsField;
      }
      set {
        this.operationStreamResultsField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class OperationStreamResult {
    private OperationResult[] operationResultsField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("operationResults")]
    public OperationResult[] operationResults {
      get {
        return this.operationResultsField;
      }
      set {
        this.operationResultsField = value;
      }
    }

    public string dummy {
      get {
        return this.dummyField;
      }
      set {
        this.dummyField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnprocessedResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnValueResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LostResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FailureResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BatchFailureResult))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class OperationResult {
    private string operationResultTypeField;

    [System.Xml.Serialization.XmlElementAttribute("OperationResult.Type")]
    public string OperationResultType {
      get {
        return this.operationResultTypeField;
      }
      set {
        this.operationResultTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class UnprocessedResult : OperationResult {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ReturnValueResult : OperationResult {
    private Operand returnValueField;

    public Operand returnValue {
      get {
        return this.returnValueField;
      }
      set {
        this.returnValueField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class LostResult : OperationResult {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class FailureResult : OperationResult {
    private ApiException causeField;

    public ApiException cause {
      get {
        return this.causeField;
      }
      set {
        this.causeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class QuotaError : ApiError {
    private QuotaErrorReason reasonField;

    private bool reasonFieldSpecified;

    private int limitField;

    private bool limitFieldSpecified;

    public QuotaErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }

    public int limit {
      get {
        return this.limitField;
      }
      set {
        this.limitField = value;
        this.limitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitSpecified {
      get {
        return this.limitFieldSpecified;
      }
      set {
        this.limitFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class PagingError : ApiError {
    private PagingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public PagingErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class OperationAccessDenied : ApiError {
    private OperationAccessDeniedReason reasonField;

    private bool reasonFieldSpecified;

    public OperationAccessDeniedReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class NewEntityCreationError : ApiError {
    private NewEntityCreationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NewEntityCreationErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class MediaError : ApiError {
    private MediaErrorReason reasonField;

    private bool reasonFieldSpecified;

    public MediaErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class JobError : ApiError {
    private JobErrorReason reasonField;

    private bool reasonFieldSpecified;

    public JobErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class ImageError : ApiError {
    private ImageErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ImageErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class IdError : ApiError {
    private IdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public IdErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterionLimitExceeded : EntityCountLimitExceeded {
    private CampaignCriterionLimitExceededCriteriaLimitType limitTypeField;

    private bool limitTypeFieldSpecified;

    public CampaignCriterionLimitExceededCriteriaLimitType limitType {
      get {
        return this.limitTypeField;
      }
      set {
        this.limitTypeField = value;
        this.limitTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitTypeSpecified {
      get {
        return this.limitTypeFieldSpecified;
      }
      set {
        this.limitTypeFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignCriterionLimitExceeded.CriteriaLimitType", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CampaignCriterionLimitExceededCriteriaLimitType {
    CAMPAIGN_NEGATIVE_KEYWORD,
    CAMPAIGN_NEGATIVE_WEBSITE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupAdCountLimitExceeded : EntityCountLimitExceeded {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class EntityAccessDenied : ApiError {
    private EntityAccessDeniedReason reasonField;

    private bool reasonFieldSpecified;

    public EntityAccessDeniedReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignError : ApiError {
    private CampaignErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterionError : ApiError {
    private CampaignCriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignCriterionErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateJobError : ApiError {
    private BulkMutateJobErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BulkMutateJobErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BiddingTransitionError : ApiError {
    private BiddingTransitionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BiddingTransitionErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupServiceError : ApiError {
    private AdGroupServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupServiceErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupAdError : ApiError {
    private AdGroupAdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupAdErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdError : ApiError {
    private AdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BatchFailureResult : OperationResult {
    private int operationIndexInBatchField;

    private bool operationIndexInBatchFieldSpecified;

    public int operationIndexInBatch {
      get {
        return this.operationIndexInBatchField;
      }
      set {
        this.operationIndexInBatchField = value;
        this.operationIndexInBatchSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operationIndexInBatchSpecified {
      get {
        return this.operationIndexInBatchFieldSpecified;
      }
      set {
        this.operationIndexInBatchFieldSpecified = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobSelector))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public abstract partial class JobSelector {
    private string[] customerJobKeysField;

    private bool includeHistoryField;

    private bool includeHistoryFieldSpecified;

    private bool includeStatsField;

    private bool includeStatsFieldSpecified;

    private string jobSelectorTypeField;

    [System.Xml.Serialization.XmlElementAttribute("customerJobKeys")]
    public string[] customerJobKeys {
      get {
        return this.customerJobKeysField;
      }
      set {
        this.customerJobKeysField = value;
      }
    }

    public bool includeHistory {
      get {
        return this.includeHistoryField;
      }
      set {
        this.includeHistoryField = value;
        this.includeHistorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeHistorySpecified {
      get {
        return this.includeHistoryFieldSpecified;
      }
      set {
        this.includeHistoryFieldSpecified = value;
      }
    }

    public bool includeStats {
      get {
        return this.includeStatsField;
      }
      set {
        this.includeStatsField = value;
        this.includeStatsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeStatsSpecified {
      get {
        return this.includeStatsFieldSpecified;
      }
      set {
        this.includeStatsFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobSelector.Type")]
    public string JobSelectorType {
      get {
        return this.jobSelectorTypeField;
      }
      set {
        this.jobSelectorTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class BulkMutateJobSelector : JobSelector {
    private long[] jobIdsField;

    private BasicJobStatus[] jobStatusesField;

    private int resultPartIndexField;

    private bool resultPartIndexFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("jobIds")]
    public long[] jobIds {
      get {
        return this.jobIdsField;
      }
      set {
        this.jobIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("jobStatuses")]
    public BasicJobStatus[] jobStatuses {
      get {
        return this.jobStatusesField;
      }
      set {
        this.jobStatusesField = value;
      }
    }

    public int resultPartIndex {
      get {
        return this.resultPartIndexField;
      }
      set {
        this.resultPartIndexField = value;
        this.resultPartIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool resultPartIndexSpecified {
      get {
        return this.resultPartIndexFieldSpecified;
      }
      set {
        this.resultPartIndexFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdExtensionOverrideServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdExtensionOverrideService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdExtensionOverrideService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/AdExtensionOverrideService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdExtensionOverridePage get(AdExtensionOverrideSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((AdExtensionOverridePage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdExtensionOverrideReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdExtensionOverrideOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdExtensionOverrideReturnValue) (results[0]));
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideReturnValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignTargetReturnValue))]
  public abstract partial class ListReturnValue {
    private string listReturnValueTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ListReturnValue.Type")]
    public string ListReturnValueType {
      get {
        return this.listReturnValueTypeField;
      }
      set {
        this.listReturnValueTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionOverrideReturnValue : ListReturnValue {
    private AdExtensionOverride[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdExtensionOverride[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionOverrideOperation : Operation {
    private AdExtensionOverride operandField;

    public AdExtensionOverride operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverridePage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignTargetPage))]
  public abstract partial class Page {
    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    private string pageTypeField;

    public int totalNumEntries {
      get {
        return this.totalNumEntriesField;
      }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get {
        return this.totalNumEntriesFieldSpecified;
      }
      set {
        this.totalNumEntriesFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Page.Type")]
    public string PageType {
      get {
        return this.pageTypeField;
      }
      set {
        this.pageTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionOverridePage : Page {
    private AdExtensionOverride[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdExtensionOverride[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionOverrideSelector {
    private long[] campaignIdsField;

    private long[] adIdsField;

    private long[] adExtensionIdsField;

    private AdExtensionOverrideStatus[] statusesField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get {
        return this.campaignIdsField;
      }
      set {
        this.campaignIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("adIds")]
    public long[] adIds {
      get {
        return this.adIdsField;
      }
      set {
        this.adIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("adExtensionIds")]
    public long[] adExtensionIds {
      get {
        return this.adExtensionIdsField;
      }
      set {
        this.adExtensionIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("statuses")]
    public AdExtensionOverrideStatus[] statuses {
      get {
        return this.statusesField;
      }
      set {
        this.statusesField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionOverrideError : ApiError {
    private AdExtensionOverrideErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdExtensionOverrideErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionOverrideError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdExtensionOverrideErrorReason {
    AD_ALREADY_HAS_ADEXTENSION_OVERRIDE,
    ADEXTENSION_ID_MUST_BE_SPECIFIED,
    ADEXTENSION_LATITUTE_CANNOT_CHANGE_AFTER_BEING_SET_ONCE,
    ADEXTENSION_LONGITUDE_CANNOT_CHANGE_AFTER_BEING_SET_ONCE,
    ADEXTENSION_NOT_UNDER_CAMPAIGN,
    CANNOT_OPERATE_ON_DELETED_OVERRIDE,
    CANNOT_OVERRIDE_EXTENSIONS_ON_NON_TEXT_AD,
    CANNOT_OVERRIDE_USING_NON_LOCATION_EXTENSION,
    INVALID_ADEXTENSION_ID,
    LOCATION_OVERRIDE_INFO_REQUIRED_FOR_NEW_LOCATION_EXTENSION_OVERRIDE,
    OVERRIDE_INFO_MUST_BE_NULL_AFTER_BEING_SET_ONCE,
    RADIUS_TOO_LARGE,
    RADIUS_TOO_SMALL,
    UNKNOWN_ADEXTENSION_OVERRIDE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupAdServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Target))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsSelector))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupAdService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupAdService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/AdGroupAdService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupAdPage get(AdGroupAdSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((AdGroupAdPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupAdReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupAdOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdGroupAdReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupAdReturnValue : ListReturnValue {
    private AdGroupAd[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupAd[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupAdPage : Page {
    private AdGroupAd[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupAd[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdStatsSelector))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionStatsSelector))]
  public partial class StatsSelector {
    private DateRange dateRangeField;

    private string statsSelectorTypeField;

    public DateRange dateRange {
      get {
        return this.dateRangeField;
      }
      set {
        this.dateRangeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("StatsSelector.Type")]
    public string StatsSelectorType {
      get {
        return this.statsSelectorTypeField;
      }
      set {
        this.statsSelectorTypeField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdStatsSelector : StatsSelector {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupAdSelector {
    private long[] campaignIdsField;

    private long[] adGroupIdsField;

    private long[] adIdsField;

    private AdStatsSelector statsSelectorField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get {
        return this.campaignIdsField;
      }
      set {
        this.campaignIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("adGroupIds")]
    public long[] adGroupIds {
      get {
        return this.adGroupIdsField;
      }
      set {
        this.adGroupIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("adIds")]
    public long[] adIds {
      get {
        return this.adIdsField;
      }
      set {
        this.adIdsField = value;
      }
    }

    public AdStatsSelector statsSelector {
      get {
        return this.statsSelectorField;
      }
      set {
        this.statsSelectorField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupCriterionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/AdGroupCriterionService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupCriterionPage get(AdGroupCriterionSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((AdGroupCriterionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupCriterionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupCriterionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdGroupCriterionReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterionReturnValue : ListReturnValue {
    private AdGroupCriterion[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupCriterion[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterionPage : Page {
    private AdGroupCriterion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupCriterion[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterionIdFilter {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    public long adGroupId {
      get {
        return this.adGroupIdField;
      }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get {
        return this.adGroupIdFieldSpecified;
      }
      set {
        this.adGroupIdFieldSpecified = value;
      }
    }

    public long criterionId {
      get {
        return this.criterionIdField;
      }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get {
        return this.criterionIdFieldSpecified;
      }
      set {
        this.criterionIdFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupCriterionSelector {
    private AdGroupCriterionIdFilter[] idFiltersField;

    private CriterionUse criterionUseField;

    private bool criterionUseFieldSpecified;

    private UserStatus[] userStatusesField;

    private StatsSelector statsSelectorField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("idFilters")]
    public AdGroupCriterionIdFilter[] idFilters {
      get {
        return this.idFiltersField;
      }
      set {
        this.idFiltersField = value;
      }
    }

    public CriterionUse criterionUse {
      get {
        return this.criterionUseField;
      }
      set {
        this.criterionUseField = value;
        this.criterionUseSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionUseSpecified {
      get {
        return this.criterionUseFieldSpecified;
      }
      set {
        this.criterionUseFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("userStatuses")]
    public UserStatus[] userStatuses {
      get {
        return this.userStatusesField;
      }
      set {
        this.userStatusesField = value;
      }
    }

    public StatsSelector statsSelector {
      get {
        return this.statsSelectorField;
      }
      set {
        this.statsSelectorField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CriterionUse {
    BIDDABLE,
    NEGATIVE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/AdGroupService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupPage get(AdGroupSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((AdGroupPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public AdGroupReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdGroupReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupReturnValue : ListReturnValue {
    private AdGroup[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroup[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupPage : Page {
    private AdGroup[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroup[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdGroupSelector {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long[] adGroupIdsField;

    private StatsSelector statsSelectorField;

    private Paging pagingField;

    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("adGroupIds")]
    public long[] adGroupIds {
      get {
        return this.adGroupIdsField;
      }
      set {
        this.adGroupIdsField = value;
      }
    }

    public StatsSelector statsSelector {
      get {
        return this.statsSelectorField;
      }
      set {
        this.statsSelectorField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignAdExtensionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsSelector))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignAdExtensionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignAdExtensionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/CampaignAdExtensionService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignAdExtensionPage get(CampaignAdExtensionSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((CampaignAdExtensionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignAdExtensionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignAdExtensionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignAdExtensionReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignAdExtensionReturnValue : ListReturnValue {
    private CampaignAdExtension[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignAdExtension[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignAdExtension {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private AdExtension adExtensionField;

    private CampaignAdExtensionStatus statusField;

    private bool statusFieldSpecified;

    private CampaignAdExtensionApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    public AdExtension adExtension {
      get {
        return this.adExtensionField;
      }
      set {
        this.adExtensionField = value;
      }
    }

    public CampaignAdExtensionStatus status {
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

    public CampaignAdExtensionApprovalStatus approvalStatus {
      get {
        return this.approvalStatusField;
      }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get {
        return this.approvalStatusFieldSpecified;
      }
      set {
        this.approvalStatusFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtension.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CampaignAdExtensionStatus {
    ACTIVE,
    DELETED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtension.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CampaignAdExtensionApprovalStatus {
    APPROVED,
    UNCHECKED,
    DISAPPROVED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignAdExtensionOperation : Operation {
    private CampaignAdExtension operandField;

    public CampaignAdExtension operand {
      get {
        return this.operandField;
      }
      set {
        this.operandField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignAdExtensionPage : Page {
    private CampaignAdExtension[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignAdExtension[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignAdExtensionStatsSelector : StatsSelector {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignAdExtensionSelector {
    private CampaignAdExtensionStatsSelector statsSelectorField;

    private long[] campaignIdsField;

    private CampaignAdExtensionStatus[] statusesField;

    private Paging pagingField;

    public CampaignAdExtensionStatsSelector statsSelector {
      get {
        return this.statsSelectorField;
      }
      set {
        this.statsSelectorField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get {
        return this.campaignIdsField;
      }
      set {
        this.campaignIdsField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("statuses")]
    public CampaignAdExtensionStatus[] statuses {
      get {
        return this.statusesField;
      }
      set {
        this.statusesField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignAdExtensionError : ApiError {
    private CampaignAdExtensionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignAdExtensionErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtensionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum CampaignAdExtensionErrorReason {
    ADEXTENSION_NOT_UNDER_CAMPAIGN,
    CANNOT_ADD_DELETED_CAMPAIGN_ADEXTENSION,
    CANNOT_OPERATE_ON_DELETED_CAMPAIGN_ADEXTENSION,
    INVALID_ADEXTENSION_ID,
    MISSING_ADEXTENSION_ID,
    MUST_USE_CONCRETE_ADEXTENSION_DURING_ADD
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class AdExtensionError : ApiError {
    private AdExtensionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdExtensionErrorReason reason {
      get {
        return this.reasonField;
      }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get {
        return this.reasonFieldSpecified;
      }
      set {
        this.reasonFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public enum AdExtensionErrorReason {
    ACCOUNT_DELETED,
    CANNOT_HAVE_MULTIPLE_LOCATION_SYNC_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_SITELINKS_EXTENSIONS_PER_CAMPAIGN,
    INVALID_AUTH_TOKEN_FOR_EMAIL,
    INVALID_COUNTRY_CODE,
    INVALID_DOMESTIC_PHONE_NUMBER_FORMAT,
    INVALID_DESTINATION_URL,
    INVALID_EMAIL,
    INVALID_ENCODED_LOCATION,
    INVALID_ID,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    INVALID_PHONE_NUMBER,
    INVALID_TOLL_PHONE_NUMBER_FORMAT,
    MEDIA_DOES_NOT_BELONG_TO_ACCOUNT,
    MEDIA_NOT_ICON_TYPE,
    MEDIA_NOT_IMAGE_TYPE,
    MISSING_ADVERTISER_NAME,
    MISSING_AUTH_TOKEN,
    MISSING_COUNTRY_CODE,
    MISSING_CITY_NAME,
    MISSING_EMAIL,
    MISSING_ENCODED_LOCATION,
    MISSING_POSTAL_CODE,
    MISSING_STREET_ADDRESS,
    NUM_LOCATION_EXTENSIONS_OVER_LIMIT,
    PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY,
    PREMIUM_RATE_NUMBER_NOT_ALLOWED,
    TOO_LONG,
    USER_NOT_PERMITTED_TO_CREATE_LBC_SYNC_LOCATION_EXTENSION
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignCriterionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/CampaignCriterionService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignCriterionPage get(CampaignCriterionSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((CampaignCriterionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignCriterionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignCriterionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignCriterionReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterionReturnValue : ListReturnValue {
    private CampaignCriterion[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignCriterion[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterionPage : Page {
    private CampaignCriterion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignCriterion[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterionIdFilter {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    public long campaignId {
      get {
        return this.campaignIdField;
      }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get {
        return this.campaignIdFieldSpecified;
      }
      set {
        this.campaignIdFieldSpecified = value;
      }
    }

    public long criterionId {
      get {
        return this.criterionIdField;
      }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get {
        return this.criterionIdFieldSpecified;
      }
      set {
        this.criterionIdFieldSpecified = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignCriterionSelector {
    private CampaignCriterionIdFilter[] idFiltersField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("idFilters")]
    public CampaignCriterionIdFilter[] idFilters {
      get {
        return this.idFiltersField;
      }
      set {
        this.idFiltersField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/CampaignService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignPage get(CampaignSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((CampaignPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignReturnValue : ListReturnValue {
    private Campaign[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Campaign[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignPage : Page {
    private Budget totalBudgetField;

    private Campaign[] entriesField;

    public Budget totalBudget {
      get {
        return this.totalBudgetField;
      }
      set {
        this.totalBudgetField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Campaign[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignSelector {
    private long[] idsField;

    private CampaignStatus[] campaignStatusesField;

    private StatsSelector statsSelectorField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("ids")]
    public long[] ids {
      get {
        return this.idsField;
      }
      set {
        this.idsField = value;
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

    public StatsSelector statsSelector {
      get {
        return this.statsSelectorField;
      }
      set {
        this.statsSelectorField = value;
      }
    }

    public Paging paging {
      get {
        return this.pagingField;
      }
      set {
        this.pagingField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignTargetServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Target))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignTargetService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignTargetService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v200909/CampaignTargetService";
    }

    public RequestHeader RequestHeader {
      get {
        return this.requestHeaderField;
      }
      set {
        this.requestHeaderField = value;
      }
    }

    public ResponseHeader ResponseHeader {
      get {
        return this.responseHeaderField;
      }
      set {
        this.responseHeaderField = value;
      }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignTargetPage get(CampaignTargetSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((CampaignTargetPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v200909", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v200909", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public CampaignTargetReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignTargetOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignTargetReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignTargetReturnValue : ListReturnValue {
    private TargetList[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public TargetList[] value {
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
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignTargetPage : Page {
    private TargetList[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public TargetList[] entries {
      get {
        return this.entriesField;
      }
      set {
        this.entriesField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v200909")]
  public partial class CampaignTargetSelector {
    private long[] campaignIdsField;
    private string dummyField;
    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get {
        return this.campaignIdsField;
      }
      set {
        this.campaignIdsField = value;
      }
    }
    public string dummy {
      get {
        return this.dummyField;
      }
      set {
        this.dummyField = value;
      }
    }
  }
}
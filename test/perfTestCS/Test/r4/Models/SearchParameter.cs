// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.Serialization;

namespace Fhir.R4.Models
{
  /// <summary>
  /// Used to define the parts of a composite search parameter.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<SearchParameterComponent>))]
  public class SearchParameterComponent : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The definition of the search parameter that describes this part.
    /// </summary>
    public string Definition { get; set; }
    /// <summary>
    /// Extension container element for Definition
    /// </summary>
    public Element _Definition { get; set; }
    /// <summary>
    /// This expression overrides the expression in the definition and extracts the index values from the outcome of the composite expression.
    /// </summary>
    public string Expression { get; set; }
    /// <summary>
    /// Extension container element for Expression
    /// </summary>
    public Element _Expression { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Definition))
      {
        writer.WriteString("definition", (string)Definition!);
      }

      if (_Definition != null)
      {
        writer.WritePropertyName("_definition");
        _Definition.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Expression))
      {
        writer.WriteString("expression", (string)Expression!);
      }

      if (_Expression != null)
      {
        writer.WritePropertyName("_expression");
        _Expression.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "definition":
          Definition = reader.GetString();
          break;

        case "_definition":
          _Definition = new Fhir.R4.Models.Element();
          _Definition.DeserializeJson(ref reader, options);
          break;

        case "expression":
          Expression = reader.GetString();
          break;

        case "_expression":
          _Expression = new Fhir.R4.Models.Element();
          _Expression.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// A search parameter that defines a named search item that can be used to search/filter on a resource.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<SearchParameter>))]
  public class SearchParameter : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "SearchParameter";
    /// <summary>
    /// A search parameter must always apply to at least one resource type. When search parameters apply to more than one resource type, they can be used against any of the listed resource types, or in a cross-type search (see [Cross Resource Search](http.html#xres-search)).
    /// </summary>
    public List<string> Base { get; set; }
    /// <summary>
    /// Extension container element for Base
    /// </summary>
    public List<Element> _Base { get; set; }
    /// <summary>
    /// Systems are not required to list all the chain names they support, but if they don't list them, clients might not know to use them.
    /// </summary>
    public List<string> Chain { get; set; }
    /// <summary>
    /// Extension container element for Chain
    /// </summary>
    public List<Element> _Chain { get; set; }
    /// <summary>
    /// For maximum compatibility, use only lowercase ASCII characters.
    /// </summary>
    public string Code { get; set; }
    /// <summary>
    /// Extension container element for Code
    /// </summary>
    public Element _Code { get; set; }
    /// <summary>
    /// If no comparators are listed, clients should not expect servers to support any comparators.
    /// </summary>
    public List<string> Comparator { get; set; }
    /// <summary>
    /// Extension container element for Comparator
    /// </summary>
    public List<Element> _Comparator { get; set; }
    /// <summary>
    /// Used to define the parts of a composite search parameter.
    /// </summary>
    public List<SearchParameterComponent> Component { get; set; }
    /// <summary>
    /// May be a web site, an email address, a telephone number, etc.
    /// </summary>
    public List<ContactDetail> Contact { get; set; }
    /// <summary>
    /// Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the search parameter. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// The intent of this is that a server can designate that it provides support for a search parameter defined in the specification itself (e.g.  [`value-quantity`](http://hl7.org/fhir/SearchParameter/Observation-value-quantity), but detail how it is supported by the server.
    /// </summary>
    public string DerivedFrom { get; set; }
    /// <summary>
    /// Extension container element for DerivedFrom
    /// </summary>
    public Element _DerivedFrom { get; set; }
    /// <summary>
    /// This description can be used to capture details such as why the search parameter was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the search parameter as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the search parameter is presumed to be the predominant language in the place the search parameter was created).
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Allows filtering of search parameters that are appropriate for use versus not.
    /// </summary>
    public bool? Experimental { get; set; }
    /// <summary>
    /// Note that the elements returned by the expression are sometimes complex elements where logic is required to determine quite how to handle them; e.g. CodeableConcepts may contain text and/or multiple codings, where the codings themselves contain a code and a system. For composite search parameters, the outcome of the expression must a collection of base elements from which the composites are derived.
    /// </summary>
    public string Expression { get; set; }
    /// <summary>
    /// Extension container element for Expression
    /// </summary>
    public Element _Expression { get; set; }
    /// <summary>
    /// It may be possible for the search parameter to be used in jurisdictions other than those for which it was originally designed or intended.
    /// </summary>
    public List<CodeableConcept> Jurisdiction { get; set; }
    /// <summary>
    /// A modifier supported for the search parameter.
    /// </summary>
    public List<string> Modifier { get; set; }
    /// <summary>
    /// Extension container element for Modifier
    /// </summary>
    public List<Element> _Modifier { get; set; }
    /// <summary>
    /// Whether multiple parameters are allowed - e.g. more than one parameter with the same name. The search matches if all the parameters match.
    /// </summary>
    public bool? MultipleAnd { get; set; }
    /// <summary>
    /// Whether multiple values are allowed for each time the parameter exists. Values are separated by commas, and the parameter matches if any of the values match.
    /// </summary>
    public bool? MultipleOr { get; set; }
    /// <summary>
    /// The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// Usually an organization but may be an individual. The publisher (or steward) of the search parameter is the organization or individual primarily responsible for the maintenance and upkeep of the search parameter. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the search parameter. This item SHOULD be populated unless the information is available from context.
    /// </summary>
    public string Publisher { get; set; }
    /// <summary>
    /// Extension container element for Publisher
    /// </summary>
    public Element _Publisher { get; set; }
    /// <summary>
    /// This element does not describe the usage of the search parameter. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this search parameter.
    /// </summary>
    public string Purpose { get; set; }
    /// <summary>
    /// Extension container element for Purpose
    /// </summary>
    public Element _Purpose { get; set; }
    /// <summary>
    /// Allows filtering of search parameters that are appropriate for use versus not.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Types of resource (if a resource is referenced).
    /// </summary>
    public List<string> Target { get; set; }
    /// <summary>
    /// Extension container element for Target
    /// </summary>
    public List<Element> _Target { get; set; }
    /// <summary>
    /// The type of value that a search parameter may contain, and how the content is interpreted.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.
    /// The determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). 
    /// In some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// Extension container element for Url
    /// </summary>
    public Element _Url { get; set; }
    /// <summary>
    /// When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.
    /// </summary>
    public List<UsageContext> UseContext { get; set; }
    /// <summary>
    /// There may be different search parameter instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the search parameter with the format [url]|[version].
    /// </summary>
    public string Version { get; set; }
    /// <summary>
    /// Extension container element for Version
    /// </summary>
    public Element _Version { get; set; }
    /// <summary>
    /// Note that the elements returned by the XPath are sometimes complex elements where logic is required to determine quite how to handle them; e.g. CodeableConcepts may contain text and/or multiple codings, where the codings themselves contain a code and a system.
    /// </summary>
    public string Xpath { get; set; }
    /// <summary>
    /// Extension container element for Xpath
    /// </summary>
    public Element _Xpath { get; set; }
    /// <summary>
    /// How the search parameter relates to the set of elements returned by evaluating the xpath query.
    /// </summary>
    public string XpathUsage { get; set; }
    /// <summary>
    /// Extension container element for XpathUsage
    /// </summary>
    public Element _XpathUsage { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((Fhir.R4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Url))
      {
        writer.WriteString("url", (string)Url!);
      }

      if (_Url != null)
      {
        writer.WritePropertyName("_url");
        _Url.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Version))
      {
        writer.WriteString("version", (string)Version!);
      }

      if (_Version != null)
      {
        writer.WritePropertyName("_version");
        _Version.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DerivedFrom))
      {
        writer.WriteString("derivedFrom", (string)DerivedFrom!);
      }

      if (_DerivedFrom != null)
      {
        writer.WritePropertyName("_derivedFrom");
        _DerivedFrom.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Experimental != null)
      {
        writer.WriteBoolean("experimental", (bool)Experimental!);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Publisher))
      {
        writer.WriteString("publisher", (string)Publisher!);
      }

      if (_Publisher != null)
      {
        writer.WritePropertyName("_publisher");
        _Publisher.SerializeJson(writer, options);
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactDetail valContact in Contact)
        {
          valContact.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if ((UseContext != null) && (UseContext.Count != 0))
      {
        writer.WritePropertyName("useContext");
        writer.WriteStartArray();

        foreach (UsageContext valUseContext in UseContext)
        {
          valUseContext.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Jurisdiction != null) && (Jurisdiction.Count != 0))
      {
        writer.WritePropertyName("jurisdiction");
        writer.WriteStartArray();

        foreach (CodeableConcept valJurisdiction in Jurisdiction)
        {
          valJurisdiction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Purpose))
      {
        writer.WriteString("purpose", (string)Purpose!);
      }

      if (_Purpose != null)
      {
        writer.WritePropertyName("_purpose");
        _Purpose.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Code))
      {
        writer.WriteString("code", (string)Code!);
      }

      if (_Code != null)
      {
        writer.WritePropertyName("_code");
        _Code.SerializeJson(writer, options);
      }

      if ((Base != null) && (Base.Count != 0))
      {
        writer.WritePropertyName("base");
        writer.WriteStartArray();

        foreach (string valBase in Base)
        {
          writer.WriteStringValue(valBase);
        }

        writer.WriteEndArray();
      }

      if ((_Base != null) && (_Base.Count != 0))
      {
        writer.WritePropertyName("_base");
        writer.WriteStartArray();

        foreach (Element val_Base in _Base)
        {
          val_Base.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Expression))
      {
        writer.WriteString("expression", (string)Expression!);
      }

      if (_Expression != null)
      {
        writer.WritePropertyName("_expression");
        _Expression.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Xpath))
      {
        writer.WriteString("xpath", (string)Xpath!);
      }

      if (_Xpath != null)
      {
        writer.WritePropertyName("_xpath");
        _Xpath.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(XpathUsage))
      {
        writer.WriteString("xpathUsage", (string)XpathUsage!);
      }

      if (_XpathUsage != null)
      {
        writer.WritePropertyName("_xpathUsage");
        _XpathUsage.SerializeJson(writer, options);
      }

      if ((Target != null) && (Target.Count != 0))
      {
        writer.WritePropertyName("target");
        writer.WriteStartArray();

        foreach (string valTarget in Target)
        {
          writer.WriteStringValue(valTarget);
        }

        writer.WriteEndArray();
      }

      if ((_Target != null) && (_Target.Count != 0))
      {
        writer.WritePropertyName("_target");
        writer.WriteStartArray();

        foreach (Element val_Target in _Target)
        {
          val_Target.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (MultipleOr != null)
      {
        writer.WriteBoolean("multipleOr", (bool)MultipleOr!);
      }

      if (MultipleAnd != null)
      {
        writer.WriteBoolean("multipleAnd", (bool)MultipleAnd!);
      }

      if ((Comparator != null) && (Comparator.Count != 0))
      {
        writer.WritePropertyName("comparator");
        writer.WriteStartArray();

        foreach (string valComparator in Comparator)
        {
          writer.WriteStringValue(valComparator);
        }

        writer.WriteEndArray();
      }

      if ((_Comparator != null) && (_Comparator.Count != 0))
      {
        writer.WritePropertyName("_comparator");
        writer.WriteStartArray();

        foreach (Element val_Comparator in _Comparator)
        {
          val_Comparator.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Modifier != null) && (Modifier.Count != 0))
      {
        writer.WritePropertyName("modifier");
        writer.WriteStartArray();

        foreach (string valModifier in Modifier)
        {
          writer.WriteStringValue(valModifier);
        }

        writer.WriteEndArray();
      }

      if ((_Modifier != null) && (_Modifier.Count != 0))
      {
        writer.WritePropertyName("_modifier");
        writer.WriteStartArray();

        foreach (Element val_Modifier in _Modifier)
        {
          val_Modifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Chain != null) && (Chain.Count != 0))
      {
        writer.WritePropertyName("chain");
        writer.WriteStartArray();

        foreach (string valChain in Chain)
        {
          writer.WriteStringValue(valChain);
        }

        writer.WriteEndArray();
      }

      if ((_Chain != null) && (_Chain.Count != 0))
      {
        writer.WritePropertyName("_chain");
        writer.WriteStartArray();

        foreach (Element val_Chain in _Chain)
        {
          val_Chain.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Component != null) && (Component.Count != 0))
      {
        writer.WritePropertyName("component");
        writer.WriteStartArray();

        foreach (SearchParameterComponent valComponent in Component)
        {
          valComponent.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "base":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Base = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Base.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Base.Count == 0)
          {
            Base = null;
          }

          break;

        case "_base":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Base = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Base = new Fhir.R4.Models.Element();
            obj_Base.DeserializeJson(ref reader, options);
            _Base.Add(obj_Base);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Base.Count == 0)
          {
            _Base = null;
          }

          break;

        case "chain":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Chain = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Chain.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Chain.Count == 0)
          {
            Chain = null;
          }

          break;

        case "_chain":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Chain = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Chain = new Fhir.R4.Models.Element();
            obj_Chain.DeserializeJson(ref reader, options);
            _Chain.Add(obj_Chain);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Chain.Count == 0)
          {
            _Chain = null;
          }

          break;

        case "code":
          Code = reader.GetString();
          break;

        case "_code":
          _Code = new Fhir.R4.Models.Element();
          _Code.DeserializeJson(ref reader, options);
          break;

        case "comparator":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Comparator = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Comparator.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Comparator.Count == 0)
          {
            Comparator = null;
          }

          break;

        case "_comparator":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Comparator = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Comparator = new Fhir.R4.Models.Element();
            obj_Comparator.DeserializeJson(ref reader, options);
            _Comparator.Add(obj_Comparator);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Comparator.Count == 0)
          {
            _Comparator = null;
          }

          break;

        case "component":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Component = new List<SearchParameterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.SearchParameterComponent objComponent = new Fhir.R4.Models.SearchParameterComponent();
            objComponent.DeserializeJson(ref reader, options);
            Component.Add(objComponent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Component.Count == 0)
          {
            Component = null;
          }

          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactDetail objContact = new Fhir.R4.Models.ContactDetail();
            objContact.DeserializeJson(ref reader, options);
            Contact.Add(objContact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contact.Count == 0)
          {
            Contact = null;
          }

          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new Fhir.R4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "derivedFrom":
          DerivedFrom = reader.GetString();
          break;

        case "_derivedFrom":
          _DerivedFrom = new Fhir.R4.Models.Element();
          _DerivedFrom.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "experimental":
          Experimental = reader.GetBoolean();
          break;

        case "expression":
          Expression = reader.GetString();
          break;

        case "_expression":
          _Expression = new Fhir.R4.Models.Element();
          _Expression.DeserializeJson(ref reader, options);
          break;

        case "jurisdiction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Jurisdiction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objJurisdiction = new Fhir.R4.Models.CodeableConcept();
            objJurisdiction.DeserializeJson(ref reader, options);
            Jurisdiction.Add(objJurisdiction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Jurisdiction.Count == 0)
          {
            Jurisdiction = null;
          }

          break;

        case "modifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Modifier = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Modifier.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Modifier.Count == 0)
          {
            Modifier = null;
          }

          break;

        case "_modifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Modifier = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Modifier = new Fhir.R4.Models.Element();
            obj_Modifier.DeserializeJson(ref reader, options);
            _Modifier.Add(obj_Modifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Modifier.Count == 0)
          {
            _Modifier = null;
          }

          break;

        case "multipleAnd":
          MultipleAnd = reader.GetBoolean();
          break;

        case "multipleOr":
          MultipleOr = reader.GetBoolean();
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "publisher":
          Publisher = reader.GetString();
          break;

        case "_publisher":
          _Publisher = new Fhir.R4.Models.Element();
          _Publisher.DeserializeJson(ref reader, options);
          break;

        case "purpose":
          Purpose = reader.GetString();
          break;

        case "_purpose":
          _Purpose = new Fhir.R4.Models.Element();
          _Purpose.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Target = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Target.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Target.Count == 0)
          {
            Target = null;
          }

          break;

        case "_target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Target = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Target = new Fhir.R4.Models.Element();
            obj_Target.DeserializeJson(ref reader, options);
            _Target.Add(obj_Target);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Target.Count == 0)
          {
            _Target = null;
          }

          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new Fhir.R4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        case "url":
          Url = reader.GetString();
          break;

        case "_url":
          _Url = new Fhir.R4.Models.Element();
          _Url.DeserializeJson(ref reader, options);
          break;

        case "useContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UseContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.UsageContext objUseContext = new Fhir.R4.Models.UsageContext();
            objUseContext.DeserializeJson(ref reader, options);
            UseContext.Add(objUseContext);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UseContext.Count == 0)
          {
            UseContext = null;
          }

          break;

        case "version":
          Version = reader.GetString();
          break;

        case "_version":
          _Version = new Fhir.R4.Models.Element();
          _Version.DeserializeJson(ref reader, options);
          break;

        case "xpath":
          Xpath = reader.GetString();
          break;

        case "_xpath":
          _Xpath = new Fhir.R4.Models.Element();
          _Xpath.DeserializeJson(ref reader, options);
          break;

        case "xpathUsage":
          XpathUsage = reader.GetString();
          break;

        case "_xpathUsage":
          _XpathUsage = new Fhir.R4.Models.Element();
          _XpathUsage.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}

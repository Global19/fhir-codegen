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
  /// The value is nested because we cannot have a repeating structure that has variable type.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<QuestionnaireResponseItemAnswer>))]
  public class QuestionnaireResponseItemAnswer : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Nested groups and/or questions found within this particular answer.
    /// </summary>
    public List<QuestionnaireResponseItem> Item { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public bool? ValueBoolean { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public decimal? ValueDecimal { get; set; }
    /// <summary>
    /// Extension container element for ValueDecimal
    /// </summary>
    public Element _ValueDecimal { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public int? ValueInteger { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public string ValueDate { get; set; }
    /// <summary>
    /// Extension container element for ValueDate
    /// </summary>
    public Element _ValueDate { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public string ValueDateTime { get; set; }
    /// <summary>
    /// Extension container element for ValueDateTime
    /// </summary>
    public Element _ValueDateTime { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public string ValueTime { get; set; }
    /// <summary>
    /// Extension container element for ValueTime
    /// </summary>
    public Element _ValueTime { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public string ValueString { get; set; }
    /// <summary>
    /// Extension container element for ValueString
    /// </summary>
    public Element _ValueString { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public string ValueUri { get; set; }
    /// <summary>
    /// Extension container element for ValueUri
    /// </summary>
    public Element _ValueUri { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public Attachment ValueAttachment { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public Coding ValueCoding { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.
    /// </summary>
    public Reference ValueReference { get; set; }
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

      if (ValueBoolean != null)
      {
        writer.WriteBoolean("valueBoolean", (bool)ValueBoolean!);
      }

      if (ValueDecimal != null)
      {
        writer.WriteNumber("valueDecimal", (decimal)ValueDecimal!);
      }

      if (_ValueDecimal != null)
      {
        writer.WritePropertyName("_valueDecimal");
        _ValueDecimal.SerializeJson(writer, options);
      }

      if (ValueInteger != null)
      {
        writer.WriteNumber("valueInteger", (int)ValueInteger!);
      }

      if (!string.IsNullOrEmpty(ValueDate))
      {
        writer.WriteString("valueDate", (string)ValueDate!);
      }

      if (_ValueDate != null)
      {
        writer.WritePropertyName("_valueDate");
        _ValueDate.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueDateTime))
      {
        writer.WriteString("valueDateTime", (string)ValueDateTime!);
      }

      if (_ValueDateTime != null)
      {
        writer.WritePropertyName("_valueDateTime");
        _ValueDateTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueTime))
      {
        writer.WriteString("valueTime", (string)ValueTime!);
      }

      if (_ValueTime != null)
      {
        writer.WritePropertyName("_valueTime");
        _ValueTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueString))
      {
        writer.WriteString("valueString", (string)ValueString!);
      }

      if (_ValueString != null)
      {
        writer.WritePropertyName("_valueString");
        _ValueString.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueUri))
      {
        writer.WriteString("valueUri", (string)ValueUri!);
      }

      if (_ValueUri != null)
      {
        writer.WritePropertyName("_valueUri");
        _ValueUri.SerializeJson(writer, options);
      }

      if (ValueAttachment != null)
      {
        writer.WritePropertyName("valueAttachment");
        ValueAttachment.SerializeJson(writer, options);
      }

      if (ValueCoding != null)
      {
        writer.WritePropertyName("valueCoding");
        ValueCoding.SerializeJson(writer, options);
      }

      if (ValueQuantity != null)
      {
        writer.WritePropertyName("valueQuantity");
        ValueQuantity.SerializeJson(writer, options);
      }

      if (ValueReference != null)
      {
        writer.WritePropertyName("valueReference");
        ValueReference.SerializeJson(writer, options);
      }

      if ((Item != null) && (Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseItem valItem in Item)
        {
          valItem.SerializeJson(writer, options, true);
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
        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Item = new List<QuestionnaireResponseItem>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.QuestionnaireResponseItem objItem = new Fhir.R4.Models.QuestionnaireResponseItem();
            objItem.DeserializeJson(ref reader, options);
            Item.Add(objItem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Item.Count == 0)
          {
            Item = null;
          }

          break;

        case "valueBoolean":
          ValueBoolean = reader.GetBoolean();
          break;

        case "valueDecimal":
          ValueDecimal = reader.GetDecimal();
          break;

        case "_valueDecimal":
          _ValueDecimal = new Fhir.R4.Models.Element();
          _ValueDecimal.DeserializeJson(ref reader, options);
          break;

        case "valueInteger":
          ValueInteger = reader.GetInt32();
          break;

        case "valueDate":
          ValueDate = reader.GetString();
          break;

        case "_valueDate":
          _ValueDate = new Fhir.R4.Models.Element();
          _ValueDate.DeserializeJson(ref reader, options);
          break;

        case "valueDateTime":
          ValueDateTime = reader.GetString();
          break;

        case "_valueDateTime":
          _ValueDateTime = new Fhir.R4.Models.Element();
          _ValueDateTime.DeserializeJson(ref reader, options);
          break;

        case "valueTime":
          ValueTime = reader.GetString();
          break;

        case "_valueTime":
          _ValueTime = new Fhir.R4.Models.Element();
          _ValueTime.DeserializeJson(ref reader, options);
          break;

        case "valueString":
          ValueString = reader.GetString();
          break;

        case "_valueString":
          _ValueString = new Fhir.R4.Models.Element();
          _ValueString.DeserializeJson(ref reader, options);
          break;

        case "valueUri":
          ValueUri = reader.GetString();
          break;

        case "_valueUri":
          _ValueUri = new Fhir.R4.Models.Element();
          _ValueUri.DeserializeJson(ref reader, options);
          break;

        case "valueAttachment":
          ValueAttachment = new Fhir.R4.Models.Attachment();
          ValueAttachment.DeserializeJson(ref reader, options);
          break;

        case "valueCoding":
          ValueCoding = new Fhir.R4.Models.Coding();
          ValueCoding.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          ValueQuantity = new Fhir.R4.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueReference":
          ValueReference = new Fhir.R4.Models.Reference();
          ValueReference.DeserializeJson(ref reader, options);
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
  /// Groups cannot have answers and therefore must nest directly within item. When dealing with questions, nesting must occur within each answer because some questions may have multiple answers (and the nesting occurs for each answer).
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<QuestionnaireResponseItem>))]
  public class QuestionnaireResponseItem : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The value is nested because we cannot have a repeating structure that has variable type.
    /// </summary>
    public List<QuestionnaireResponseItemAnswer> Answer { get; set; }
    /// <summary>
    /// The ElementDefinition must be in a [StructureDefinition](structuredefinition.html#), and must have a fragment identifier that identifies the specific data element by its id (Element.id). E.g. http://hl7.org/fhir/StructureDefinition/Observation#Observation.value[x].
    /// There is no need for this element if the item pointed to by the linkId has a definition listed.
    /// </summary>
    public string Definition { get; set; }
    /// <summary>
    /// Extension container element for Definition
    /// </summary>
    public Element _Definition { get; set; }
    /// <summary>
    /// Questions or sub-groups nested beneath a question or group.
    /// </summary>
    public List<QuestionnaireResponseItem> Item { get; set; }
    /// <summary>
    /// The item from the Questionnaire that corresponds to this item in the QuestionnaireResponse resource.
    /// </summary>
    public string LinkId { get; set; }
    /// <summary>
    /// Extension container element for LinkId
    /// </summary>
    public Element _LinkId { get; set; }
    /// <summary>
    /// Text that is displayed above the contents of the group or as the text of the question being answered.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
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

      if (!string.IsNullOrEmpty(LinkId))
      {
        writer.WriteString("linkId", (string)LinkId!);
      }

      if (_LinkId != null)
      {
        writer.WritePropertyName("_linkId");
        _LinkId.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Definition))
      {
        writer.WriteString("definition", (string)Definition!);
      }

      if (_Definition != null)
      {
        writer.WritePropertyName("_definition");
        _Definition.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
      }

      if ((Answer != null) && (Answer.Count != 0))
      {
        writer.WritePropertyName("answer");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseItemAnswer valAnswer in Answer)
        {
          valAnswer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Item != null) && (Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseItem valItem in Item)
        {
          valItem.SerializeJson(writer, options, true);
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
        case "answer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Answer = new List<QuestionnaireResponseItemAnswer>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.QuestionnaireResponseItemAnswer objAnswer = new Fhir.R4.Models.QuestionnaireResponseItemAnswer();
            objAnswer.DeserializeJson(ref reader, options);
            Answer.Add(objAnswer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Answer.Count == 0)
          {
            Answer = null;
          }

          break;

        case "definition":
          Definition = reader.GetString();
          break;

        case "_definition":
          _Definition = new Fhir.R4.Models.Element();
          _Definition.DeserializeJson(ref reader, options);
          break;

        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Item = new List<QuestionnaireResponseItem>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.QuestionnaireResponseItem objItem = new Fhir.R4.Models.QuestionnaireResponseItem();
            objItem.DeserializeJson(ref reader, options);
            Item.Add(objItem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Item.Count == 0)
          {
            Item = null;
          }

          break;

        case "linkId":
          LinkId = reader.GetString();
          break;

        case "_linkId":
          _LinkId = new Fhir.R4.Models.Element();
          _LinkId.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new Fhir.R4.Models.Element();
          _Text.DeserializeJson(ref reader, options);
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
  /// A structured set of questions and their answers. The questions are ordered and grouped into coherent subsets, corresponding to the structure of the grouping of the questionnaire being responded to.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<QuestionnaireResponse>))]
  public class QuestionnaireResponse : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "QuestionnaireResponse";
    /// <summary>
    /// Mapping a subject's answers to multiple choice options and determining what to put in the textual answer is a matter of interpretation.  Authoring by device would indicate that some portion of the questionnaire had been auto-populated.
    /// </summary>
    public Reference Author { get; set; }
    /// <summary>
    /// May be different from the lastUpdateTime of the resource itself, because that reflects when the data was known to the server, not when the data was captured.
    /// This element is optional to allow for systems that might not know the value, however it SHOULD be populated if possible.
    /// </summary>
    public string Authored { get; set; }
    /// <summary>
    /// Extension container element for Authored
    /// </summary>
    public Element _Authored { get; set; }
    /// <summary>
    /// The order, proposal or plan that is fulfilled in whole or in part by this QuestionnaireResponse.  For example, a ServiceRequest seeking an intake assessment or a decision support recommendation to assess for post-partum depression.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter. A questionnaire that was initiated during an encounter but not fully completed during the encounter would still generally be associated with the encounter.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// A business identifier assigned to a particular completed (or partially completed) questionnaire.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// Groups cannot have answers and therefore must nest directly within item. When dealing with questions, nesting must occur within each answer because some questions may have multiple answers (and the nesting occurs for each answer).
    /// </summary>
    public List<QuestionnaireResponseItem> Item { get; set; }
    /// <summary>
    /// Composition of questionnaire responses will be handled by the parent questionnaire having answers that reference the child questionnaire.  For relationships to referrals, and other types of requests, use basedOn.
    /// </summary>
    public List<Reference> PartOf { get; set; }
    /// <summary>
    /// If a QuestionnaireResponse references a Questionnaire, then the QuestionnaireResponse structure must be consistent with the Questionnaire (i.e. questions must be organized into the same groups, nested questions must still be nested, etc.).
    /// </summary>
    public string Questionnaire { get; set; }
    /// <summary>
    /// Extension container element for Questionnaire
    /// </summary>
    public Element _Questionnaire { get; set; }
    /// <summary>
    /// If not specified, no inference can be made about who provided the data.
    /// </summary>
    public Reference Source { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// If the Questionnaire declared a subjectType, the resource pointed to by this element must be an instance of one of the listed types.
    /// </summary>
    public Reference Subject { get; set; }
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

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if ((BasedOn != null) && (BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();

        foreach (Reference valBasedOn in BasedOn)
        {
          valBasedOn.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((PartOf != null) && (PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();

        foreach (Reference valPartOf in PartOf)
        {
          valPartOf.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Questionnaire))
      {
        writer.WriteString("questionnaire", (string)Questionnaire!);
      }

      if (_Questionnaire != null)
      {
        writer.WritePropertyName("_questionnaire");
        _Questionnaire.SerializeJson(writer, options);
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

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Authored))
      {
        writer.WriteString("authored", (string)Authored!);
      }

      if (_Authored != null)
      {
        writer.WritePropertyName("_authored");
        _Authored.SerializeJson(writer, options);
      }

      if (Author != null)
      {
        writer.WritePropertyName("author");
        Author.SerializeJson(writer, options);
      }

      if (Source != null)
      {
        writer.WritePropertyName("source");
        Source.SerializeJson(writer, options);
      }

      if ((Item != null) && (Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();

        foreach (QuestionnaireResponseItem valItem in Item)
        {
          valItem.SerializeJson(writer, options, true);
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
        case "author":
          Author = new Fhir.R4.Models.Reference();
          Author.DeserializeJson(ref reader, options);
          break;

        case "authored":
          Authored = reader.GetString();
          break;

        case "_authored":
          _Authored = new Fhir.R4.Models.Element();
          _Authored.DeserializeJson(ref reader, options);
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objBasedOn = new Fhir.R4.Models.Reference();
            objBasedOn.DeserializeJson(ref reader, options);
            BasedOn.Add(objBasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BasedOn.Count == 0)
          {
            BasedOn = null;
          }

          break;

        case "encounter":
          Encounter = new Fhir.R4.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new Fhir.R4.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Item = new List<QuestionnaireResponseItem>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.QuestionnaireResponseItem objItem = new Fhir.R4.Models.QuestionnaireResponseItem();
            objItem.DeserializeJson(ref reader, options);
            Item.Add(objItem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Item.Count == 0)
          {
            Item = null;
          }

          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PartOf = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objPartOf = new Fhir.R4.Models.Reference();
            objPartOf.DeserializeJson(ref reader, options);
            PartOf.Add(objPartOf);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PartOf.Count == 0)
          {
            PartOf = null;
          }

          break;

        case "questionnaire":
          Questionnaire = reader.GetString();
          break;

        case "_questionnaire":
          _Questionnaire = new Fhir.R4.Models.Element();
          _Questionnaire.DeserializeJson(ref reader, options);
          break;

        case "source":
          Source = new Fhir.R4.Models.Reference();
          Source.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new Fhir.R4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
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

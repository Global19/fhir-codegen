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
  /// All the identified characteristics must be true for an entity to a member of the group.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<GroupCharacteristic>))]
  public class GroupCharacteristic : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A code that identifies the kind of trait being asserted.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// This is labeled as "Is Modifier" because applications cannot wrongly include excluded members as included or vice versa.
    /// </summary>
    public bool Exclude { get; set; }
    /// <summary>
    /// The period over which the characteristic is tested; e.g. the patient had an operation during the month of June.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// For Range, it means members of the group have a value that falls somewhere within the specified range.
    /// </summary>
    public CodeableConcept ValueCodeableConcept { get; set; }
    /// <summary>
    /// For Range, it means members of the group have a value that falls somewhere within the specified range.
    /// </summary>
    public bool ValueBoolean { get; set; }
    /// <summary>
    /// For Range, it means members of the group have a value that falls somewhere within the specified range.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// For Range, it means members of the group have a value that falls somewhere within the specified range.
    /// </summary>
    public Range ValueRange { get; set; }
    /// <summary>
    /// For Range, it means members of the group have a value that falls somewhere within the specified range.
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

      writer.WritePropertyName("code");
      Code.SerializeJson(writer, options);

      writer.WritePropertyName("valueCodeableConcept");
      ValueCodeableConcept.SerializeJson(writer, options);

      writer.WriteBoolean("valueBoolean", ValueBoolean);

      writer.WritePropertyName("valueQuantity");
      ValueQuantity.SerializeJson(writer, options);

      writer.WritePropertyName("valueRange");
      ValueRange.SerializeJson(writer, options);

      writer.WritePropertyName("valueReference");
      ValueReference.SerializeJson(writer, options);

      writer.WriteBoolean("exclude", Exclude);

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
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
        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "exclude":
          Exclude = reader.GetBoolean();
          break;

        case "period":
          Period = new Fhir.R4.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          ValueCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          ValueCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "valueBoolean":
          ValueBoolean = reader.GetBoolean();
          break;

        case "valueQuantity":
          ValueQuantity = new Fhir.R4.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueRange":
          ValueRange = new Fhir.R4.Models.Range();
          ValueRange.DeserializeJson(ref reader, options);
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
  /// Identifies the resource instances that are members of the group.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<GroupMember>))]
  public class GroupMember : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A reference to the entity that is a member of the group. Must be consistent with Group.type. If the entity is another group, then the type must be the same.
    /// </summary>
    public Reference Entity { get; set; }
    /// <summary>
    /// A flag to indicate that the member is no longer in the group, but previously may have been a member.
    /// </summary>
    public bool? Inactive { get; set; }
    /// <summary>
    /// The period that the member was in the group, if known.
    /// </summary>
    public Period Period { get; set; }
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

      writer.WritePropertyName("entity");
      Entity.SerializeJson(writer, options);

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if (Inactive != null)
      {
        writer.WriteBoolean("inactive", (bool)Inactive!);
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
        case "entity":
          Entity = new Fhir.R4.Models.Reference();
          Entity.DeserializeJson(ref reader, options);
          break;

        case "inactive":
          Inactive = reader.GetBoolean();
          break;

        case "period":
          Period = new Fhir.R4.Models.Period();
          Period.DeserializeJson(ref reader, options);
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
  /// Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively, and are not formally or legally recognized; i.e. a collection of entities that isn't an Organization.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<Group>))]
  public class Group : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Group";
    /// <summary>
    /// Indicates whether the record for the group is available for use or is merely being retained for historical purposes.
    /// </summary>
    public bool? Active { get; set; }
    /// <summary>
    /// If true, indicates that the resource refers to a specific group of real individuals.  If false, the group defines a set of intended individuals.
    /// </summary>
    public bool Actual { get; set; }
    /// <summary>
    /// All the identified characteristics must be true for an entity to a member of the group.
    /// </summary>
    public List<GroupCharacteristic> Characteristic { get; set; }
    /// <summary>
    /// This would generally be omitted for Person resources.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// A unique business identifier for this group.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This does not strictly align with ownership of a herd or flock, but may suffice to represent that relationship in simple cases. More complex cases will require an extension.
    /// </summary>
    public Reference ManagingEntity { get; set; }
    /// <summary>
    /// Identifies the resource instances that are members of the group.
    /// </summary>
    public List<GroupMember> Member { get; set; }
    /// <summary>
    /// A label assigned to the group for human identification and communication.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// Note that the quantity may be less than the number of members if some of the members are not active.
    /// </summary>
    public uint? Quantity { get; set; }
    /// <summary>
    /// Group members SHALL be of the appropriate resource type (Patient for person or animal; or Practitioner, Device, Medication or Substance for the other types.).
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
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

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Active != null)
      {
        writer.WriteBoolean("active", (bool)Active!);
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

      writer.WriteBoolean("actual", Actual);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
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

      if (Quantity != null)
      {
        writer.WriteNumber("quantity", (uint)Quantity!);
      }

      if (ManagingEntity != null)
      {
        writer.WritePropertyName("managingEntity");
        ManagingEntity.SerializeJson(writer, options);
      }

      if ((Characteristic != null) && (Characteristic.Count != 0))
      {
        writer.WritePropertyName("characteristic");
        writer.WriteStartArray();

        foreach (GroupCharacteristic valCharacteristic in Characteristic)
        {
          valCharacteristic.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Member != null) && (Member.Count != 0))
      {
        writer.WritePropertyName("member");
        writer.WriteStartArray();

        foreach (GroupMember valMember in Member)
        {
          valMember.SerializeJson(writer, options, true);
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
        case "active":
          Active = reader.GetBoolean();
          break;

        case "actual":
          Actual = reader.GetBoolean();
          break;

        case "characteristic":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Characteristic = new List<GroupCharacteristic>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.GroupCharacteristic objCharacteristic = new Fhir.R4.Models.GroupCharacteristic();
            objCharacteristic.DeserializeJson(ref reader, options);
            Characteristic.Add(objCharacteristic);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Characteristic.Count == 0)
          {
            Characteristic = null;
          }

          break;

        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Identifier objIdentifier = new Fhir.R4.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "managingEntity":
          ManagingEntity = new Fhir.R4.Models.Reference();
          ManagingEntity.DeserializeJson(ref reader, options);
          break;

        case "member":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Member = new List<GroupMember>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.GroupMember objMember = new Fhir.R4.Models.GroupMember();
            objMember.DeserializeJson(ref reader, options);
            Member.Add(objMember);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Member.Count == 0)
          {
            Member = null;
          }

          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = reader.GetUInt32();
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new Fhir.R4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
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

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
  /// Indicates who or what performed the event.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MedicationDispensePerformer>))]
  public class MedicationDispensePerformer : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The device, practitioner, etc. who performed the action.  It should be assumed that the actor is the dispenser of the medication.
    /// </summary>
    public Reference Actor { get; set; }
    /// <summary>
    /// Distinguishes the type of performer in the dispense.  For example, date enterer, packager, final checker.
    /// </summary>
    public CodeableConcept Function { get; set; }
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

      if (Function != null)
      {
        writer.WritePropertyName("function");
        Function.SerializeJson(writer, options);
      }

      writer.WritePropertyName("actor");
      Actor.SerializeJson(writer, options);

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
        case "actor":
          Actor = new Fhir.R4.Models.Reference();
          Actor.DeserializeJson(ref reader, options);
          break;

        case "function":
          Function = new Fhir.R4.Models.CodeableConcept();
          Function.DeserializeJson(ref reader, options);
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
  /// Indicates whether or not substitution was made as part of the dispense.  In some cases, substitution will be expected but does not happen, in other cases substitution is not expected but does happen.  This block explains what substitution did or did not happen and why.  If nothing is specified, substitution was not done.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MedicationDispenseSubstitution>))]
  public class MedicationDispenseSubstitution : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Indicates the reason for the substitution (or lack of substitution) from what was prescribed.
    /// </summary>
    public List<CodeableConcept> Reason { get; set; }
    /// <summary>
    /// The person or organization that has primary responsibility for the substitution.
    /// </summary>
    public List<Reference> ResponsibleParty { get; set; }
    /// <summary>
    /// A code signifying whether a different drug was dispensed from what was prescribed.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// True if the dispenser dispensed a different drug or product from what was prescribed.
    /// </summary>
    public bool WasSubstituted { get; set; }
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

      writer.WriteBoolean("wasSubstituted", WasSubstituted);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if ((Reason != null) && (Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();

        foreach (CodeableConcept valReason in Reason)
        {
          valReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ResponsibleParty != null) && (ResponsibleParty.Count != 0))
      {
        writer.WritePropertyName("responsibleParty");
        writer.WriteStartArray();

        foreach (Reference valResponsibleParty in ResponsibleParty)
        {
          valResponsibleParty.SerializeJson(writer, options, true);
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
        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objReason = new Fhir.R4.Models.CodeableConcept();
            objReason.DeserializeJson(ref reader, options);
            Reason.Add(objReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reason.Count == 0)
          {
            Reason = null;
          }

          break;

        case "responsibleParty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ResponsibleParty = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objResponsibleParty = new Fhir.R4.Models.Reference();
            objResponsibleParty.DeserializeJson(ref reader, options);
            ResponsibleParty.Add(objResponsibleParty);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ResponsibleParty.Count == 0)
          {
            ResponsibleParty = null;
          }

          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "wasSubstituted":
          WasSubstituted = reader.GetBoolean();
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
  /// Indicates that a medication product is to be or has been dispensed for a named person/patient.  This includes a description of the medication product (supply) provided and the instructions for administering the medication.  The medication dispense is the result of a pharmacy system responding to a medication order.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MedicationDispense>))]
  public class MedicationDispense : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "MedicationDispense";
    /// <summary>
    /// Maps to basedOn in Event logical model.
    /// </summary>
    public List<Reference> AuthorizingPrescription { get; set; }
    /// <summary>
    /// The category can be used to include where the medication is expected to be consumed or other types of dispenses.  Invariants can be used to bind to different value sets when profiling to bind.
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// The encounter or episode of care that establishes the context for this event.
    /// </summary>
    public Reference Context { get; set; }
    /// <summary>
    /// The amount of medication expressed as a timing amount.
    /// </summary>
    public Quantity DaysSupply { get; set; }
    /// <summary>
    /// Identification of the facility/location where the medication was shipped to, as part of the dispense event.
    /// </summary>
    public Reference Destination { get; set; }
    /// <summary>
    /// This element can include a detected issue that has been identified either by a decision support system or by a clinician and may include information on the steps that were taken to address the issue.
    /// </summary>
    public List<Reference> DetectedIssue { get; set; }
    /// <summary>
    /// When the dose or rate is intended to change over the entire administration period (e.g. Tapering dose prescriptions), multiple instances of dosage instructions will need to be supplied to convey the different doses/rates.
    /// The pharmacist reviews the medication order prior to dispense and updates the dosageInstruction based on the actual product being dispensed.
    /// </summary>
    public List<Dosage> DosageInstruction { get; set; }
    /// <summary>
    /// This might not include provenances for all versions of the request – only those deemed “relevant” or important. This SHALL NOT include the Provenance associated with this current version of the resource. (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update. Until then, it can be queried directly as the Provenance that points to this version using _revinclude All Provenances should have some historical version of this Request as their subject.).
    /// </summary>
    public List<Reference> EventHistory { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The principal physical location where the dispense was performed.
    /// </summary>
    public Reference Location { get; set; }
    /// <summary>
    /// If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number, then you must reference the Medication resource.
    /// </summary>
    public CodeableConcept MedicationCodeableConcept { get; set; }
    /// <summary>
    /// If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number, then you must reference the Medication resource.
    /// </summary>
    public Reference MedicationReference { get; set; }
    /// <summary>
    /// Extra information about the dispense that could not be conveyed in the other attributes.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// The procedure that trigger the dispense.
    /// </summary>
    public List<Reference> PartOf { get; set; }
    /// <summary>
    /// Indicates who or what performed the event.
    /// </summary>
    public List<MedicationDispensePerformer> Performer { get; set; }
    /// <summary>
    /// The amount of medication that has been dispensed. Includes unit of measure.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// Identifies the person who picked up the medication.  This will usually be a patient or their caregiver, but some cases exist where it can be a healthcare professional.
    /// </summary>
    public List<Reference> Receiver { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Indicates the reason why a dispense was not performed.
    /// </summary>
    public CodeableConcept StatusReasonCodeableConcept { get; set; }
    /// <summary>
    /// Indicates the reason why a dispense was not performed.
    /// </summary>
    public Reference StatusReasonReference { get; set; }
    /// <summary>
    /// SubstanceAdministration-&gt;subject-&gt;Patient.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Indicates whether or not substitution was made as part of the dispense.  In some cases, substitution will be expected but does not happen, in other cases substitution is not expected but does happen.  This block explains what substitution did or did not happen and why.  If nothing is specified, substitution was not done.
    /// </summary>
    public MedicationDispenseSubstitution Substitution { get; set; }
    /// <summary>
    /// Additional information that supports the medication being dispensed.
    /// </summary>
    public List<Reference> SupportingInformation { get; set; }
    /// <summary>
    /// Indicates the type of dispensing event that is performed. For example, Trial Fill, Completion of Trial, Partial Fill, Emergency Fill, Samples, etc.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// The time the dispensed product was provided to the patient or their representative.
    /// </summary>
    public string WhenHandedOver { get; set; }
    /// <summary>
    /// Extension container element for WhenHandedOver
    /// </summary>
    public Element _WhenHandedOver { get; set; }
    /// <summary>
    /// The time when the dispensed product was packaged and reviewed.
    /// </summary>
    public string WhenPrepared { get; set; }
    /// <summary>
    /// Extension container element for WhenPrepared
    /// </summary>
    public Element _WhenPrepared { get; set; }
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (StatusReasonCodeableConcept != null)
      {
        writer.WritePropertyName("statusReasonCodeableConcept");
        StatusReasonCodeableConcept.SerializeJson(writer, options);
      }

      if (StatusReasonReference != null)
      {
        writer.WritePropertyName("statusReasonReference");
        StatusReasonReference.SerializeJson(writer, options);
      }

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
      }

      writer.WritePropertyName("medicationCodeableConcept");
      MedicationCodeableConcept.SerializeJson(writer, options);

      writer.WritePropertyName("medicationReference");
      MedicationReference.SerializeJson(writer, options);

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Context != null)
      {
        writer.WritePropertyName("context");
        Context.SerializeJson(writer, options);
      }

      if ((SupportingInformation != null) && (SupportingInformation.Count != 0))
      {
        writer.WritePropertyName("supportingInformation");
        writer.WriteStartArray();

        foreach (Reference valSupportingInformation in SupportingInformation)
        {
          valSupportingInformation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Performer != null) && (Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();

        foreach (MedicationDispensePerformer valPerformer in Performer)
        {
          valPerformer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Location != null)
      {
        writer.WritePropertyName("location");
        Location.SerializeJson(writer, options);
      }

      if ((AuthorizingPrescription != null) && (AuthorizingPrescription.Count != 0))
      {
        writer.WritePropertyName("authorizingPrescription");
        writer.WriteStartArray();

        foreach (Reference valAuthorizingPrescription in AuthorizingPrescription)
        {
          valAuthorizingPrescription.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if (DaysSupply != null)
      {
        writer.WritePropertyName("daysSupply");
        DaysSupply.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(WhenPrepared))
      {
        writer.WriteString("whenPrepared", (string)WhenPrepared!);
      }

      if (_WhenPrepared != null)
      {
        writer.WritePropertyName("_whenPrepared");
        _WhenPrepared.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(WhenHandedOver))
      {
        writer.WriteString("whenHandedOver", (string)WhenHandedOver!);
      }

      if (_WhenHandedOver != null)
      {
        writer.WritePropertyName("_whenHandedOver");
        _WhenHandedOver.SerializeJson(writer, options);
      }

      if (Destination != null)
      {
        writer.WritePropertyName("destination");
        Destination.SerializeJson(writer, options);
      }

      if ((Receiver != null) && (Receiver.Count != 0))
      {
        writer.WritePropertyName("receiver");
        writer.WriteStartArray();

        foreach (Reference valReceiver in Receiver)
        {
          valReceiver.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((DosageInstruction != null) && (DosageInstruction.Count != 0))
      {
        writer.WritePropertyName("dosageInstruction");
        writer.WriteStartArray();

        foreach (Dosage valDosageInstruction in DosageInstruction)
        {
          valDosageInstruction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Substitution != null)
      {
        writer.WritePropertyName("substitution");
        Substitution.SerializeJson(writer, options);
      }

      if ((DetectedIssue != null) && (DetectedIssue.Count != 0))
      {
        writer.WritePropertyName("detectedIssue");
        writer.WriteStartArray();

        foreach (Reference valDetectedIssue in DetectedIssue)
        {
          valDetectedIssue.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((EventHistory != null) && (EventHistory.Count != 0))
      {
        writer.WritePropertyName("eventHistory");
        writer.WriteStartArray();

        foreach (Reference valEventHistory in EventHistory)
        {
          valEventHistory.SerializeJson(writer, options, true);
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
        case "authorizingPrescription":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          AuthorizingPrescription = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objAuthorizingPrescription = new Fhir.R4.Models.Reference();
            objAuthorizingPrescription.DeserializeJson(ref reader, options);
            AuthorizingPrescription.Add(objAuthorizingPrescription);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (AuthorizingPrescription.Count == 0)
          {
            AuthorizingPrescription = null;
          }

          break;

        case "category":
          Category = new Fhir.R4.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "context":
          Context = new Fhir.R4.Models.Reference();
          Context.DeserializeJson(ref reader, options);
          break;

        case "daysSupply":
          DaysSupply = new Fhir.R4.Models.Quantity();
          DaysSupply.DeserializeJson(ref reader, options);
          break;

        case "destination":
          Destination = new Fhir.R4.Models.Reference();
          Destination.DeserializeJson(ref reader, options);
          break;

        case "detectedIssue":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DetectedIssue = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objDetectedIssue = new Fhir.R4.Models.Reference();
            objDetectedIssue.DeserializeJson(ref reader, options);
            DetectedIssue.Add(objDetectedIssue);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DetectedIssue.Count == 0)
          {
            DetectedIssue = null;
          }

          break;

        case "dosageInstruction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DosageInstruction = new List<Dosage>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Dosage objDosageInstruction = new Fhir.R4.Models.Dosage();
            objDosageInstruction.DeserializeJson(ref reader, options);
            DosageInstruction.Add(objDosageInstruction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DosageInstruction.Count == 0)
          {
            DosageInstruction = null;
          }

          break;

        case "eventHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          EventHistory = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objEventHistory = new Fhir.R4.Models.Reference();
            objEventHistory.DeserializeJson(ref reader, options);
            EventHistory.Add(objEventHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (EventHistory.Count == 0)
          {
            EventHistory = null;
          }

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

        case "location":
          Location = new Fhir.R4.Models.Reference();
          Location.DeserializeJson(ref reader, options);
          break;

        case "medicationCodeableConcept":
          MedicationCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          MedicationCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "medicationReference":
          MedicationReference = new Fhir.R4.Models.Reference();
          MedicationReference.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Annotation objNote = new Fhir.R4.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
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

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Performer = new List<MedicationDispensePerformer>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MedicationDispensePerformer objPerformer = new Fhir.R4.Models.MedicationDispensePerformer();
            objPerformer.DeserializeJson(ref reader, options);
            Performer.Add(objPerformer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Performer.Count == 0)
          {
            Performer = null;
          }

          break;

        case "quantity":
          Quantity = new Fhir.R4.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "receiver":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Receiver = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objReceiver = new Fhir.R4.Models.Reference();
            objReceiver.DeserializeJson(ref reader, options);
            Receiver.Add(objReceiver);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Receiver.Count == 0)
          {
            Receiver = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "statusReasonCodeableConcept":
          StatusReasonCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          StatusReasonCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "statusReasonReference":
          StatusReasonReference = new Fhir.R4.Models.Reference();
          StatusReasonReference.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new Fhir.R4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "substitution":
          Substitution = new Fhir.R4.Models.MedicationDispenseSubstitution();
          Substitution.DeserializeJson(ref reader, options);
          break;

        case "supportingInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingInformation = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objSupportingInformation = new Fhir.R4.Models.Reference();
            objSupportingInformation.DeserializeJson(ref reader, options);
            SupportingInformation.Add(objSupportingInformation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingInformation.Count == 0)
          {
            SupportingInformation = null;
          }

          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "whenHandedOver":
          WhenHandedOver = reader.GetString();
          break;

        case "_whenHandedOver":
          _WhenHandedOver = new Fhir.R4.Models.Element();
          _WhenHandedOver.DeserializeJson(ref reader, options);
          break;

        case "whenPrepared":
          WhenPrepared = reader.GetString();
          break;

        case "_whenPrepared":
          _WhenPrepared = new Fhir.R4.Models.Element();
          _WhenPrepared.DeserializeJson(ref reader, options);
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

// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 4.4.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// A pharmaceutical product described in terms of its composition and dose form
  /// </summary>
#if !NETSTANDARD1_1
  [Serializable]
#endif
  [FhirType("AdministrableProductDefinition", IsResource=true)]
  [DataContract]
  public partial class AdministrableProductDefinition : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "AdministrableProductDefinition"; } }

    /// <summary>
    /// Characteristics e.g. a products onset of action
    /// </summary>
    [FhirType("AdministrableProductDefinition#Property", IsNestedType=true)]
    [DataContract]
    public partial class PropertyComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "AdministrableProductDefinition#Property"; } }

      /// <summary>
      /// A code expressing the type of characteristic
      /// </summary>
      [FhirElement("type", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      /// <summary>
      /// A value for the characteristic
      /// </summary>
      [FhirElement("value", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.Quantity),typeof(Hl7.Fhir.Model.Date),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Attachment))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.DataType _Value;

      /// <summary>
      /// The status of characteristic e.g. assigned or pending
      /// </summary>
      [FhirElement("status", InSummary=true, Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Status
      {
        get { return _Status; }
        set { _Status = value; OnPropertyChanged("Status"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Status;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PropertyComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.DataType)Value.DeepCopy();
        if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PropertyComponent());
      }

      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;
        if( !DeepComparable.Matches(Status, otherT.Status)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
        if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Type != null) yield return Type;
          if (Value != null) yield return Value;
          if (Status != null) yield return Status;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Type != null) yield return new ElementValue("type", Type);
          if (Value != null) yield return new ElementValue("value", Value);
          if (Status != null) yield return new ElementValue("status", Status);
        }
      }

    }

    /// <summary>
    /// The path by which the pharmaceutical product is taken into or makes contact with the body
    /// </summary>
    [FhirType("AdministrableProductDefinition#RouteOfAdministration", IsNestedType=true)]
    [DataContract]
    public partial class RouteOfAdministrationComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "AdministrableProductDefinition#RouteOfAdministration"; } }

      /// <summary>
      /// Coded expression for the route
      /// </summary>
      [FhirElement("code", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// The first dose (dose quantity) administered in humans can be specified, for a product under investigation, using a numerical value and its unit of measurement
      /// </summary>
      [FhirElement("firstDose", InSummary=true, Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity FirstDose
      {
        get { return _FirstDose; }
        set { _FirstDose = value; OnPropertyChanged("FirstDose"); }
      }

      private Hl7.Fhir.Model.Quantity _FirstDose;

      /// <summary>
      /// The maximum single dose that can be administered as per the protocol of a clinical trial can be specified using a numerical value and its unit of measurement
      /// </summary>
      [FhirElement("maxSingleDose", InSummary=true, Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity MaxSingleDose
      {
        get { return _MaxSingleDose; }
        set { _MaxSingleDose = value; OnPropertyChanged("MaxSingleDose"); }
      }

      private Hl7.Fhir.Model.Quantity _MaxSingleDose;

      /// <summary>
      /// The maximum dose per day (maximum dose quantity to be administered in any one 24-h period) that can be administered as per the protocol referenced in the clinical trial authorisation
      /// </summary>
      [FhirElement("maxDosePerDay", InSummary=true, Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity MaxDosePerDay
      {
        get { return _MaxDosePerDay; }
        set { _MaxDosePerDay = value; OnPropertyChanged("MaxDosePerDay"); }
      }

      private Hl7.Fhir.Model.Quantity _MaxDosePerDay;

      /// <summary>
      /// The maximum dose per treatment period that can be administered as per the protocol referenced in the clinical trial authorisation
      /// </summary>
      [FhirElement("maxDosePerTreatmentPeriod", InSummary=true, Order=80)]
      [DataMember]
      public Hl7.Fhir.Model.Ratio MaxDosePerTreatmentPeriod
      {
        get { return _MaxDosePerTreatmentPeriod; }
        set { _MaxDosePerTreatmentPeriod = value; OnPropertyChanged("MaxDosePerTreatmentPeriod"); }
      }

      private Hl7.Fhir.Model.Ratio _MaxDosePerTreatmentPeriod;

      /// <summary>
      /// The maximum treatment period during which an Investigational Medicinal Product can be administered as per the protocol referenced in the clinical trial authorisation
      /// </summary>
      [FhirElement("maxTreatmentPeriod", InSummary=true, Order=90)]
      [DataMember]
      public Hl7.Fhir.Model.Duration MaxTreatmentPeriod
      {
        get { return _MaxTreatmentPeriod; }
        set { _MaxTreatmentPeriod = value; OnPropertyChanged("MaxTreatmentPeriod"); }
      }

      private Hl7.Fhir.Model.Duration _MaxTreatmentPeriod;

      /// <summary>
      /// A species for which this route applies
      /// </summary>
      [FhirElement("targetSpecies", InSummary=true, Order=100)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.AdministrableProductDefinition.TargetSpeciesComponent> TargetSpecies
      {
        get { if(_TargetSpecies==null) _TargetSpecies = new List<Hl7.Fhir.Model.AdministrableProductDefinition.TargetSpeciesComponent>(); return _TargetSpecies; }
        set { _TargetSpecies = value; OnPropertyChanged("TargetSpecies"); }
      }

      private List<Hl7.Fhir.Model.AdministrableProductDefinition.TargetSpeciesComponent> _TargetSpecies;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as RouteOfAdministrationComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(FirstDose != null) dest.FirstDose = (Hl7.Fhir.Model.Quantity)FirstDose.DeepCopy();
        if(MaxSingleDose != null) dest.MaxSingleDose = (Hl7.Fhir.Model.Quantity)MaxSingleDose.DeepCopy();
        if(MaxDosePerDay != null) dest.MaxDosePerDay = (Hl7.Fhir.Model.Quantity)MaxDosePerDay.DeepCopy();
        if(MaxDosePerTreatmentPeriod != null) dest.MaxDosePerTreatmentPeriod = (Hl7.Fhir.Model.Ratio)MaxDosePerTreatmentPeriod.DeepCopy();
        if(MaxTreatmentPeriod != null) dest.MaxTreatmentPeriod = (Hl7.Fhir.Model.Duration)MaxTreatmentPeriod.DeepCopy();
        if(TargetSpecies != null) dest.TargetSpecies = new List<Hl7.Fhir.Model.AdministrableProductDefinition.TargetSpeciesComponent>(TargetSpecies.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new RouteOfAdministrationComponent());
      }

      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as RouteOfAdministrationComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(FirstDose, otherT.FirstDose)) return false;
        if( !DeepComparable.Matches(MaxSingleDose, otherT.MaxSingleDose)) return false;
        if( !DeepComparable.Matches(MaxDosePerDay, otherT.MaxDosePerDay)) return false;
        if( !DeepComparable.Matches(MaxDosePerTreatmentPeriod, otherT.MaxDosePerTreatmentPeriod)) return false;
        if( !DeepComparable.Matches(MaxTreatmentPeriod, otherT.MaxTreatmentPeriod)) return false;
        if( !DeepComparable.Matches(TargetSpecies, otherT.TargetSpecies)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as RouteOfAdministrationComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(FirstDose, otherT.FirstDose)) return false;
        if( !DeepComparable.IsExactly(MaxSingleDose, otherT.MaxSingleDose)) return false;
        if( !DeepComparable.IsExactly(MaxDosePerDay, otherT.MaxDosePerDay)) return false;
        if( !DeepComparable.IsExactly(MaxDosePerTreatmentPeriod, otherT.MaxDosePerTreatmentPeriod)) return false;
        if( !DeepComparable.IsExactly(MaxTreatmentPeriod, otherT.MaxTreatmentPeriod)) return false;
        if( !DeepComparable.IsExactly(TargetSpecies, otherT.TargetSpecies)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (FirstDose != null) yield return FirstDose;
          if (MaxSingleDose != null) yield return MaxSingleDose;
          if (MaxDosePerDay != null) yield return MaxDosePerDay;
          if (MaxDosePerTreatmentPeriod != null) yield return MaxDosePerTreatmentPeriod;
          if (MaxTreatmentPeriod != null) yield return MaxTreatmentPeriod;
          foreach (var elem in TargetSpecies) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (FirstDose != null) yield return new ElementValue("firstDose", FirstDose);
          if (MaxSingleDose != null) yield return new ElementValue("maxSingleDose", MaxSingleDose);
          if (MaxDosePerDay != null) yield return new ElementValue("maxDosePerDay", MaxDosePerDay);
          if (MaxDosePerTreatmentPeriod != null) yield return new ElementValue("maxDosePerTreatmentPeriod", MaxDosePerTreatmentPeriod);
          if (MaxTreatmentPeriod != null) yield return new ElementValue("maxTreatmentPeriod", MaxTreatmentPeriod);
          foreach (var elem in TargetSpecies) { if (elem != null) yield return new ElementValue("targetSpecies", elem); }
        }
      }

    }

    /// <summary>
    /// A species for which this route applies
    /// </summary>
    [FhirType("AdministrableProductDefinition#TargetSpecies", IsNestedType=true)]
    [DataContract]
    public partial class TargetSpeciesComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "AdministrableProductDefinition#TargetSpecies"; } }

      /// <summary>
      /// Coded expression for the species
      /// </summary>
      [FhirElement("code", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// A species specific time during which consumption of animal product is not appropriate
      /// </summary>
      [FhirElement("withdrawalPeriod", InSummary=true, Order=50)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.AdministrableProductDefinition.WithdrawalPeriodComponent> WithdrawalPeriod
      {
        get { if(_WithdrawalPeriod==null) _WithdrawalPeriod = new List<Hl7.Fhir.Model.AdministrableProductDefinition.WithdrawalPeriodComponent>(); return _WithdrawalPeriod; }
        set { _WithdrawalPeriod = value; OnPropertyChanged("WithdrawalPeriod"); }
      }

      private List<Hl7.Fhir.Model.AdministrableProductDefinition.WithdrawalPeriodComponent> _WithdrawalPeriod;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as TargetSpeciesComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(WithdrawalPeriod != null) dest.WithdrawalPeriod = new List<Hl7.Fhir.Model.AdministrableProductDefinition.WithdrawalPeriodComponent>(WithdrawalPeriod.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new TargetSpeciesComponent());
      }

      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as TargetSpeciesComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(WithdrawalPeriod, otherT.WithdrawalPeriod)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as TargetSpeciesComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(WithdrawalPeriod, otherT.WithdrawalPeriod)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          foreach (var elem in WithdrawalPeriod) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          foreach (var elem in WithdrawalPeriod) { if (elem != null) yield return new ElementValue("withdrawalPeriod", elem); }
        }
      }

    }

    /// <summary>
    /// A species specific time during which consumption of animal product is not appropriate
    /// </summary>
    [FhirType("AdministrableProductDefinition#WithdrawalPeriod", IsNestedType=true)]
    [DataContract]
    public partial class WithdrawalPeriodComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "AdministrableProductDefinition#WithdrawalPeriod"; } }

      /// <summary>
      /// Coded expression for the type of tissue for which the withdrawal period applues, e.g. meat, milk
      /// </summary>
      [FhirElement("tissue", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Tissue
      {
        get { return _Tissue; }
        set { _Tissue = value; OnPropertyChanged("Tissue"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Tissue;

      /// <summary>
      /// A value for the time
      /// </summary>
      [FhirElement("value", InSummary=true, Order=50)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.Quantity _Value;

      /// <summary>
      /// Extra information about the withdrawal period
      /// </summary>
      [FhirElement("supportingInformation", InSummary=true, Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString SupportingInformationElement
      {
        get { return _SupportingInformationElement; }
        set { _SupportingInformationElement = value; OnPropertyChanged("SupportingInformationElement"); }
      }

      private Hl7.Fhir.Model.FhirString _SupportingInformationElement;

      /// <summary>
      /// Extra information about the withdrawal period
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string SupportingInformation
      {
        get { return SupportingInformationElement != null ? SupportingInformationElement.Value : null; }
        set
        {
          if (value == null)
            SupportingInformationElement = null;
          else
            SupportingInformationElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("SupportingInformation");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as WithdrawalPeriodComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Tissue != null) dest.Tissue = (Hl7.Fhir.Model.CodeableConcept)Tissue.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.Quantity)Value.DeepCopy();
        if(SupportingInformationElement != null) dest.SupportingInformationElement = (Hl7.Fhir.Model.FhirString)SupportingInformationElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new WithdrawalPeriodComponent());
      }

      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as WithdrawalPeriodComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Tissue, otherT.Tissue)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;
        if( !DeepComparable.Matches(SupportingInformationElement, otherT.SupportingInformationElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as WithdrawalPeriodComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Tissue, otherT.Tissue)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
        if( !DeepComparable.IsExactly(SupportingInformationElement, otherT.SupportingInformationElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Tissue != null) yield return Tissue;
          if (Value != null) yield return Value;
          if (SupportingInformationElement != null) yield return SupportingInformationElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Tissue != null) yield return new ElementValue("tissue", Tissue);
          if (Value != null) yield return new ElementValue("value", Value);
          if (SupportingInformationElement != null) yield return new ElementValue("supportingInformation", SupportingInformationElement);
        }
      }

    }

    /// <summary>
    /// An identifier for the pharmaceutical medicinal product
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// The product that this is a pharmaceutical product of
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("MedicinalProductDefinition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Subject
    {
      get { if(_Subject==null) _Subject = new List<Hl7.Fhir.Model.ResourceReference>(); return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Subject;

    /// <summary>
    /// The administrable dose form, after necessary reconstitution
    /// </summary>
    [FhirElement("administrableDoseForm", InSummary=true, Order=110)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept AdministrableDoseForm
    {
      get { return _AdministrableDoseForm; }
      set { _AdministrableDoseForm = value; OnPropertyChanged("AdministrableDoseForm"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _AdministrableDoseForm;

    /// <summary>
    /// Todo
    /// </summary>
    [FhirElement("unitOfPresentation", InSummary=true, Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept UnitOfPresentation
    {
      get { return _UnitOfPresentation; }
      set { _UnitOfPresentation = value; OnPropertyChanged("UnitOfPresentation"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _UnitOfPresentation;

    /// <summary>
    /// The manufactured item(s) that this administrable product is produced from. Either a single item, or several that are mixed before administration (e.g. a power item and a solution item). Note that these are not raw ingredients
    /// </summary>
    [FhirElement("producedFrom", InSummary=true, Order=130)]
    [CLSCompliant(false)]
    [References("ManufacturedItemDefinition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ProducedFrom
    {
      get { if(_ProducedFrom==null) _ProducedFrom = new List<Hl7.Fhir.Model.ResourceReference>(); return _ProducedFrom; }
      set { _ProducedFrom = value; OnPropertyChanged("ProducedFrom"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ProducedFrom;

    /// <summary>
    /// The ingredients of this administrable pharmaceutical product
    /// </summary>
    [FhirElement("ingredient", InSummary=true, Order=140)]
    [CLSCompliant(false)]
    [References("Ingredient")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Ingredient
    {
      get { if(_Ingredient==null) _Ingredient = new List<Hl7.Fhir.Model.ResourceReference>(); return _Ingredient; }
      set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Ingredient;

    /// <summary>
    /// Accompanying device
    /// </summary>
    [FhirElement("device", InSummary=true, Order=150)]
    [CLSCompliant(false)]
    [References("DeviceDefinition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Device
    {
      get { if(_Device==null) _Device = new List<Hl7.Fhir.Model.ResourceReference>(); return _Device; }
      set { _Device = value; OnPropertyChanged("Device"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Device;

    /// <summary>
    /// Characteristics e.g. a products onset of action
    /// </summary>
    [FhirElement("property", InSummary=true, Order=160)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.AdministrableProductDefinition.PropertyComponent> Property
    {
      get { if(_Property==null) _Property = new List<Hl7.Fhir.Model.AdministrableProductDefinition.PropertyComponent>(); return _Property; }
      set { _Property = value; OnPropertyChanged("Property"); }
    }

    private List<Hl7.Fhir.Model.AdministrableProductDefinition.PropertyComponent> _Property;

    /// <summary>
    /// The path by which the pharmaceutical product is taken into or makes contact with the body
    /// </summary>
    [FhirElement("routeOfAdministration", InSummary=true, Order=170)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.AdministrableProductDefinition.RouteOfAdministrationComponent> RouteOfAdministration
    {
      get { if(_RouteOfAdministration==null) _RouteOfAdministration = new List<Hl7.Fhir.Model.AdministrableProductDefinition.RouteOfAdministrationComponent>(); return _RouteOfAdministration; }
      set { _RouteOfAdministration = value; OnPropertyChanged("RouteOfAdministration"); }
    }

    private List<Hl7.Fhir.Model.AdministrableProductDefinition.RouteOfAdministrationComponent> _RouteOfAdministration;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as AdministrableProductDefinition;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Subject != null) dest.Subject = new List<Hl7.Fhir.Model.ResourceReference>(Subject.DeepCopy());
      if(AdministrableDoseForm != null) dest.AdministrableDoseForm = (Hl7.Fhir.Model.CodeableConcept)AdministrableDoseForm.DeepCopy();
      if(UnitOfPresentation != null) dest.UnitOfPresentation = (Hl7.Fhir.Model.CodeableConcept)UnitOfPresentation.DeepCopy();
      if(ProducedFrom != null) dest.ProducedFrom = new List<Hl7.Fhir.Model.ResourceReference>(ProducedFrom.DeepCopy());
      if(Ingredient != null) dest.Ingredient = new List<Hl7.Fhir.Model.ResourceReference>(Ingredient.DeepCopy());
      if(Device != null) dest.Device = new List<Hl7.Fhir.Model.ResourceReference>(Device.DeepCopy());
      if(Property != null) dest.Property = new List<Hl7.Fhir.Model.AdministrableProductDefinition.PropertyComponent>(Property.DeepCopy());
      if(RouteOfAdministration != null) dest.RouteOfAdministration = new List<Hl7.Fhir.Model.AdministrableProductDefinition.RouteOfAdministrationComponent>(RouteOfAdministration.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new AdministrableProductDefinition());
    }

    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as AdministrableProductDefinition;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(AdministrableDoseForm, otherT.AdministrableDoseForm)) return false;
      if( !DeepComparable.Matches(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
      if( !DeepComparable.Matches(ProducedFrom, otherT.ProducedFrom)) return false;
      if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.Matches(Device, otherT.Device)) return false;
      if( !DeepComparable.Matches(Property, otherT.Property)) return false;
      if( !DeepComparable.Matches(RouteOfAdministration, otherT.RouteOfAdministration)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as AdministrableProductDefinition;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(AdministrableDoseForm, otherT.AdministrableDoseForm)) return false;
      if( !DeepComparable.IsExactly(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
      if( !DeepComparable.IsExactly(ProducedFrom, otherT.ProducedFrom)) return false;
      if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
      if( !DeepComparable.IsExactly(Property, otherT.Property)) return false;
      if( !DeepComparable.IsExactly(RouteOfAdministration, otherT.RouteOfAdministration)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in Subject) { if (elem != null) yield return elem; }
        if (AdministrableDoseForm != null) yield return AdministrableDoseForm;
        if (UnitOfPresentation != null) yield return UnitOfPresentation;
        foreach (var elem in ProducedFrom) { if (elem != null) yield return elem; }
        foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
        foreach (var elem in Device) { if (elem != null) yield return elem; }
        foreach (var elem in Property) { if (elem != null) yield return elem; }
        foreach (var elem in RouteOfAdministration) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
        if (AdministrableDoseForm != null) yield return new ElementValue("administrableDoseForm", AdministrableDoseForm);
        if (UnitOfPresentation != null) yield return new ElementValue("unitOfPresentation", UnitOfPresentation);
        foreach (var elem in ProducedFrom) { if (elem != null) yield return new ElementValue("producedFrom", elem); }
        foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
        foreach (var elem in Device) { if (elem != null) yield return new ElementValue("device", elem); }
        foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
        foreach (var elem in RouteOfAdministration) { if (elem != null) yield return new ElementValue("routeOfAdministration", elem); }
      }
    }

  }

}

// end of file

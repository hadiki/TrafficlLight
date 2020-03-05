using System;

namespace Ampel
{
   public interface ISwitch
   {
      bool On { get; }

      void Switch();
   }

   public interface IIdentifiable
   {
      Guid RecordID { get; }
   }
   public interface IPersistable : IIdentifiable
   {
      void Save();
   }

   class Person : IPersistable
   {
      public Guid RecordID => throw new NotImplementedException();

      public void Save()
      {
         throw new NotImplementedException();
      }
   }
}

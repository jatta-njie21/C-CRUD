using System;
namespace Crud.BLL
{
    public interface ICrudBLL
    {
            private _recordProviderDAL;

            int InsertRecord(ICrudDTO record);
           
            public void UpdateRecord(IRecordDTO record);
            
            public RecordDTO DeleteRecord(int b_id);
            
            public RecordDTO LoadRecord(int b_id);
           
            public IRecordSearchResultDTO SearchRecord(ISearchParameterDTO searchParameters);
            
    }
}

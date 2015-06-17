using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAEntity;

namespace BilgeAnaokulu.UserController
{
    public interface ICRUDuc
    {
        BAInput BACRUDInput { get; set; }

        void BACRUDInsert();

        void BACRUDUpdate();

        void BACRUDDelete();

        List<BAInput> BACRUDGetAll();

        void BACRUDLoadDetail();

        void BACRUDClearComp();

        bool BACRUDCheck();
    }
}

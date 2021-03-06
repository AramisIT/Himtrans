﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Core;
using Aramis.Platform.SystemSetup;
using Aramis.SystemConfigurations;

namespace Aramis.GreenHouse
    {
    public class CheckHimTransSolutionDBStruct : CheckSolutionDBStruct
        {
        #region Хранимые процедуры и функции решения
        private List<string> beforeTableCreateSP = new List<string>();
        private List<string> afterTableCreateSP = new List<string>()
            {

            };
        #endregion


        protected override void CheckSolutionTables()
            {
            base.CheckSolutionTables();

            // Создание хранимых процедур и функций решения которые не зависят от таблиц БД
            Aramis.SystemConfigurations.SystemCheckers.CheckSPExistings.RewriteByList(beforeTableCreateSP);
            // Удаление хранимых процедур и функций которые зависят от БД
            Aramis.SystemConfigurations.SystemCheckers.CheckSPExistings.DeleteByList(afterTableCreateSP);

            //// Создание таблиц для объектов БД 
            //if (needShowObjectForm)
            //    {
            //    new Aramis.DBUpdate.UpdateDBStructureForm().ShowDialog();
            //    }
            //else
            //    {
            //    new Aramis.DBUpdate.UpdateDBStructureForm().UpdateWithoutShowing();
            //    }
            // Создание хранимых процедур для отчетов
            CheckReportsSP();
            // Создание хранимых процедур и функций которые зависят от БД
            Aramis.SystemConfigurations.SystemCheckers.CheckSPExistings.CreateByList(afterTableCreateSP);
            }

        private void CheckReportsSP()
            {
            foreach (InfoOfReport info in SystemConfiguration.ReportsTree.Values)
                {
                SystemConfigurations.SystemCheckers.CheckSPExistings.RewriteByList(((Report)System.Activator.CreateInstance(info.Type)).GetReportSP());
                }
            }
        
        internal void Check()
            {
            CheckSolutionTables();
            }
        }
    }

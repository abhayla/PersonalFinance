﻿using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Contracts
{
    public interface IMutualFundDataAccess
    {
        DataTable GetFolios();
        DataTable GetFundCategory();
        DataTable GetFundHouses();
        DataTable GetFundOptions();
        DataTable GetFunds();
        DataTable GetFundTypes();
        DataTable GetPortFolios();

        DataTable GetPortfolioTransactions(GetMFTransactions getMFTransactions);
        DataTable GetFundTransactions(GetMFTransactions getMFTransactions);
        DataTable AddUpdateMFTransaction(AddMFTransactionRequest _mfTransactionRequest);
        DataTable AddDividend(AddDividendRequest _dividendRequest);
        DataTable UpdateLatestNAV(List<NAVData> data);
        DataTable GetFundsPerformance();

        void BackUpNAVData();
        void UpdateNAVHistory(List<NAVData> data);
        DataTable GetFundNav(DateTime date);


        string GetLastProcessedDetails();
    }
}
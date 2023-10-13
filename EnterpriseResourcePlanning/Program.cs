
using EnterpriseResourcePlanning.Models;
using EnterpriseResourcePlanning.Modules;

var firstHR = new HRModule();
firstHR.Run();

FinanceModule financeModule = new FinanceModule();
financeModule.Run();


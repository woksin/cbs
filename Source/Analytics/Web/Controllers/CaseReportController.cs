using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Read.CaseReports;
using Read.Models.CaseReports;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseReportController : ControllerBase
    {
        private readonly CaseReportRepository _caseReportRepository;
        public CaseReportController(CaseReportRepository caseReportRepository)
        {
            _caseReportRepository = caseReportRepository;
        }

        [HttpGet("Totals/{from}/{to}", Name = "GetCaseReportTotals")]
        public ActionResult<CaseReportTotals> GetCaseReportTotals(DateTimeOffset from, DateTimeOffset to)
        {
            return _caseReportRepository.GetCaseReportTotals(from, to);
        }

        [HttpGet("TotalsPerHealthRisk/{numberOfWeeks}", Name = "GetCaseReportTotalsPerHealthRisk")]
        public ActionResult<List<CaseReportTotalsPerHealthRisk>> GetCaseReportTotalsPerHealthRisk(int numberOfWeeks)
        {
            return _caseReportRepository.GetCaseReportTotalsPerHealthRisk(numberOfWeeks);
        }
    }
}
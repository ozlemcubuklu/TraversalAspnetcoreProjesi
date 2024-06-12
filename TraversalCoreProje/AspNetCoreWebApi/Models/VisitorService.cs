﻿using AspNetCoreWebApi.DAL;
using AspNetCoreWebApi.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Models
{
    public class VisitorService
    {
        private readonly Context _context;
        private readonly IHubContext<VisitorHub> _hubContext;

        public VisitorService(Context context, IHubContext<VisitorHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }
        public IQueryable<Visitor> GetList()
        {
            return _context.Visitors.AsQueryable();
        }
        public async Task SaveVisitor(Visitor visitor)
        {
            await _context.AddAsync(visitor);
           await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("CallVisitorList","aaa");

        }
        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using (var command = _context.Database.GetDbConnection().CreateCommand()) {
                command.CommandText = "query sorgu";
                _context.Database.OpenConnection();
                using (var reader=command.ExecuteReader()) {
                    while (reader.Read()) { 
                    VisitorChart visitorChart = new VisitorChart();
                        visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString();
                        Enumerable.Range(1, 5).ToList().ForEach(x => {
                            visitorChart.Counts.Add(reader.GetInt32(x));
                            });
                        visitorCharts.Add(visitorChart);
                    
                    
                    }
                }

                _context.Database.CloseConnection();
                return visitorCharts;

            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfinance_web_netcore.Domain.Entities;
using myfinance_web_netcore.Domain.Services.Interfaces;
using myfinance_web_netcore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace myfinance_web_netcore.Domain.Services
{
  public class TipoPagamentoService : ITipoPagamentoService
  {
    private readonly MyFinanceDbContext _dbContext;

    public TipoPagamentoService(MyFinanceDbContext dbContext) 
    {
      _dbContext = dbContext;
    }

    List<TipoPagamentoModel> ITipoPagamentoService.ListarRegistros()
    {
      var result = new List<TipoPagamentoModel>();
      var dbSet = _dbContext.TipoPagamento;

      foreach (var item in dbSet)
      {
        var itemTipoPagamento = new TipoPagamentoModel()
        {
          Id = item.Id,
          Tipo = item.Tipo
        };

        result.Add(itemTipoPagamento);
      }

      return result;
    }
  }
}
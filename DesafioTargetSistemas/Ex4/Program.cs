const double fatSP = 67836.43, fatRJ = 36678.66, fatMG = 29229.88, fatES = 27165.48, fatOutros = 19849.53;

const double fatTotal = fatSP + fatRJ + fatMG + fatES + fatOutros;

mostraPorcentagemFaturamento("SP", fatSP, fatTotal);
mostraPorcentagemFaturamento("RJ", fatRJ, fatTotal);
mostraPorcentagemFaturamento("MG", fatMG, fatTotal);
mostraPorcentagemFaturamento("ES", fatES, fatTotal);
mostraPorcentagemFaturamento("outros", fatOutros, fatTotal);

void mostraPorcentagemFaturamento(String estado, double faturamentoEstado, double faturamentoTotal)
{
    Console.WriteLine($"Porcentagem do faturamento de {estado}: {faturamentoEstado / faturamentoTotal * 100}%");
}
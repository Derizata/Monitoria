using System;

public class Monitor
{
    private String nomeMonitor;
    private String siglaLab;
    private String diaMonitoria;
    private String horario;



    public Monitor(String nomeMonitor, String siglaLab, String diaMonitoria, String horario)
    {
        this.nomeMonitor = nomeMonitor;
        this.siglaLab = siglaLab;
        this.diaMonitoria = diaMonitoria;
        this.horario = horario;
    }

    public String NomeMonitor
    {
        get { return this.nomeMonitor; }        
    }
    public String SiglaLab
    {
        get { return this.siglaLab; }
    }
    public String DiaMonitoria
    {
        get { return this.diaMonitoria; }
    }
    public String Horario
    {
        get { return this.horario; }
    }

    public virtual string ToString()
    {
        return "Nome: " + nomeMonitor + "\nLaboratório: " + siglaLab + "\nDias: " + diaMonitoria + "\nHorarios: " + horario;
    }
}

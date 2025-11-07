using AwesomeAssertions;

namespace RutinaMatutinaTDD;

public class RutinaMatutinaTest
{

    [Theory]
    [InlineData(6,0,0)]
    [InlineData(6,15,0)]
    [InlineData(6,59,0)]
    [InlineData(6,45,0)]
    public void Dada_HoraActualEstaEntre6_00Y6_59_Cuando_ConsultoQueDeboEstarHaciendo_Entonces_RetornarHacerEjercicio(int horas, int minutos, int segundos)
    {
        var rutinaMatutina = new RutinaMatutina();
        rutinaMatutina.horaActual = new TimeSpan(horas, minutos, segundos);

        var actividadActual = rutinaMatutina.QueDeboEstarHaciendoAhora();

        actividadActual.Should().Be("Hacer ejercicio");
    }
    
    [Theory]
    [InlineData(7,30,0)]
    [InlineData(7,0,0)]
    [InlineData(7,59,0)]
    [InlineData(7,18,0)]
    public void Dada_HoraActualEstaEntre7_00Y7_59_Cuando_ConsultoQueDeboEstarHaciendo_Entonces_RetornarLeeryestudiar(int horas, int minutos, int segundos)
    {
        var rutinaMatutina = new RutinaMatutina();
        rutinaMatutina.horaActual = new TimeSpan(horas, minutos, segundos);

        var actividadActual = rutinaMatutina.QueDeboEstarHaciendoAhora();

        actividadActual.Should().Be("Leer y estudiar");
    }
    
}

public class RutinaMatutina
{
    public TimeSpan horaActual;

    public string QueDeboEstarHaciendoAhora()
    {
        if (horaActual >= new TimeSpan(7, 0, 0) && horaActual <= new TimeSpan(7, 59, 0))
            return "Leer y estudiar";

        if (horaActual >= new TimeSpan(6, 0, 0) && horaActual <= new TimeSpan(6, 59, 0))
            return "Hacer ejercicio";
        
        throw new NotImplementedException();
    }
    
}
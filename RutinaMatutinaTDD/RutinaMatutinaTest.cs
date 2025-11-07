using AwesomeAssertions;

namespace RutinaMatutinaTDD;

public class RutinaMatutinaTest
{
    [Fact]
    public void Dada_HoraActual6_00_Cuando_ConsultoQueDeboEstarHaciendo_Entonces_RetornarHacerEjercicio()
    {
        var rutinaMatutina = new RutinaMatutina();
        rutinaMatutina.horaActual = new TimeSpan(6, 0, 0);

        var actividadActual = rutinaMatutina.QueDeboEstarHaciendoAhora();

        actividadActual.Should().Be("Hacer ejercicio");

    }
    
}

public class RutinaMatutina
{
    public TimeSpan horaActual;

    public object QueDeboEstarHaciendoAhora()
    {
        throw new NotImplementedException();
    }
    
}
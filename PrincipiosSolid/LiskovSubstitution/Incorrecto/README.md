public static void imprimirNumAsientos(Coche[] arrayCoches){  
    for (Coche coche : arrayCoches) {
        if(coche instanceof Renault)
            System.out.println(numAsientosRenault(coche));
        if(coche instanceof Audi)
            System.out.println(numAsientosAudi(coche));
        if(coche instanceof Mercedes)
            System.out.println(numAsientosMercedes(coche));
    }
}
imprimirNumAsientos(arrayCoches);  
Esto viola tanto el principio de substitución de Liskov como el de abierto/cerrado. 
El programa debe conocer cada tipo de Coche y llamar a su método numAsientos() asociado.

Así, si añadimos un nuevo coche, el método debe modificarse para aceptarlo.

// ...
Coche[] arrayCoches = {  
        new Renault(),
        new Audi(),
        new Mercedes(),
        new Ford()
};

public static void imprimirNumAsientos(Coche[] arrayCoches){  
    for (Coche coche : arrayCoches) {
        if(coche instanceof Renault)
            System.out.println(numAsientosRenault(coche));
        if(coche instanceof Audi)
            System.out.println(numAsientosAudi(coche));
        if(coche instanceof Mercedes)
            System.out.println(numAsientosMercedes(coche));
        if(coche instanceof Ford)
            System.out.println(numAsientosFord(coche));
    }
}
imprimirNumAsientos(arrayCoches);

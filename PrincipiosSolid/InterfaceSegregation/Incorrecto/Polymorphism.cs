namespace PrincipiosSolid.InterfaceSegregation.Incorrecto
{
    class Polymorphism
    {
        public void test()
        {
            IAdd iadd = new Calculator();
            iadd.Add(2, 2);
            //I can't execute substract
            //iadd.Substract(2, 2);
        }

        public IAdd test2(IAdd iAdd) {
            return iAdd;
        }
    }
}

using System;

    public class IGateW
    {
        async Task<List<Register>> salesReport([FromBody] int[] year);
        async Task<List<Register>> salesReport2([FromBody] int[] year);
        async Task<List<Register3>> salesReport3([FromBody] int[] year);
        public async Task<UserModel> auth(LoginCredentials auth);
        async Task<List<PersonInfo>> listPerson();
        async Task<PersonInfo> getPerson(int id);
        async Task<Boolean> deletePerson(int id);
        async Task<Boolean> addPerson(PersonInfo person);
        async Task<Boolean> updatePerson(PersonInfo person);
    }


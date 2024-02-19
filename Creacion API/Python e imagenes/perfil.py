class Perfil:
    def __init__(self, personal_id, dominio, educantabria, password, perfil):
        self.personal_id = personal_id
        self.dominio = dominio
        self.educantabria = educantabria
        self.password = password
        self.perfil = perfil

    def get_personal_id(self):
        return self.personal_id

    def set_personal_id(self, value):
        self.personal_id = value
        
    def get_dominio(self):
        return self.dominio

    def set_dominio(self, value):
        self.dominio = value
    
    def get_educantabria(self):
        return self.educantabria

    def set_educantabria(self, value):
        self.educantabria = value
    
    def get_password(self):
        return self.password

    def set_password(self, value):
        self.password = value
        
    def get_perfil(self):
        return self.perfil

    def set_perfil(self, value):
        self.perfil = value
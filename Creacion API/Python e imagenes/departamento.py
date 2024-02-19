class Departamento:
    def __init__(self, int, cod, nombre, activo, jefedep_id):
        self.int = int
        self.cod = cod
        self.nombre = nombre
        self.activo = activo
        self.jefedep_id = jefedep_id

    def get_int(self):
        return self.int

    def set_int(self, value):
        self.int = value
        
    def get_cod(self):
        return self.cod

    def set_cod(self, value):
        self.cod = value
    
    def get_nombre(self):
        return self.nombre

    def set_nombre(self, value):
        self.nombre = value
    
    def get_activo(self):
        return self.activo

    def set_activo(self, value):
        self.activo = value
        
    def get_jefedep_id(self):
        return self.jefedep_id

    def set_jefedep_id(self, value):
        self.jefedep_id = value
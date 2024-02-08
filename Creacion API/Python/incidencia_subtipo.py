class Incidencia_subtipo:
    def __init__(self, id, tipo, subtipo_nombre, sub_subtipo):
        self.id= id
        self.tipo = tipo
        self.subtipo_nombre = subtipo_nombre
        self.sub_subtipo = sub_subtipo

    def get_id(self):
        return self.id

    def set_id(self, value):
        self.id = value
        
    def get_tipo(self):
        return self.tipo

    def set_tipo(self, value):
        self.tipo = value
    
    def get_subtipo_nombre(self):
        return self.subtipo_nombre

    def set_subtipo_nombre(self, value):
        self.subtipo_nombre = value
    
    def get_sub_subtipo(self):
        return self.sub_subtipo

    def set_sub_subtipo(self, value):
        self.sub_subtipo = value
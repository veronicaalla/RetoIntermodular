class Aula:
    def __init__(self, num, codigo, descripcion, planta):
        self.num = num
        self.codigo = codigo
        self.descripcion = descripcion
        self.planta = planta

    def get_num(self):
        return self.num

    def set_num(self, value):
        self.num = value
        
    def get_codigo(self):
        return self.codigo

    def set_codigo(self, value):
        self.codigo = value
        
    def get_descripcion(self):
        return self.descripcion

    def set_descripcion(self, value):
        self.descripcion = value
        
    def get_planta(self):
        return self.planta

    def set_planta(self, value):
        self.planta = value
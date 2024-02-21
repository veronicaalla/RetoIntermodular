class Equipo:
    def __init__(self, id, tipo_equipo, fecha_adquisicion, etiqueta, marca, modelo, descripcion, baja, aula_num, puesto):
        self.id = id
        self.tipo_equipo = tipo_equipo
        self.fecha_adquisicion = fecha_adquisicion
        self.etiqueta = etiqueta
        self.marca = marca
        self.modelo = modelo
        self.descripcion = descripcion
        self.baja = baja
        self.aula_num = aula_num
        self.puesto = puesto

    def get_id(self):
        return self.id

    def set_id(self, value):
        self.id = value
        
    def get_tipo_equipo(self):
        return self.tipo_equipo

    def set_tipo_equipo(self, value):
        self.tipo_equipo = value
    
    def get_fecha_adquisicion(self):
        return self.fecha_adquisicion

    def set_fecha_adquisicion(self, value):
        self.fecha_adquisicion = value
    
    def get_etiqueta(self):
        return self.etiqueta

    def set_etiqueta(self, value):
        self.etiqueta = value
        
    def get_marca(self):
        return self.marca

    def set_marca(self, value):
        self.marca = value
         
    def get_modelo(self):
        return self.modelo

    def set_modelo(self, value):
        self.modelo = value
        
    def get_descripcion(self):
        return self.descripcion

    def set_descripcion(self, value):
        self.descripcion = value
        
    def get_baja(self):
        return self.baja

    def set_baja(self, value):
        self.baja = value
        
    def get_aula_num(self):
        return self.aula_num

    def set_aula_num(self, value):
        self.aula_num = value
        
    def get_puesto(self):
        return self.puesto

    def set_puesto(self, value):
        self.puesto = value
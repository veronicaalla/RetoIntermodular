class Comentario:
    def __init__(self, id, texto, fechahora, incidencia_num, personal_id, adjunto_url):
        self.id = id
        self.texto = texto
        self.fechahora = fechahora
        self.incidencia_num = incidencia_num
        self.personal_id = personal_id
        self.adjunto_url = adjunto_url

    def get_id(self):
        return self.id

    def set_id(self, value):
        self.id = value
        
    def get_texto(self):
        return self.texto

    def set_texto(self, value):
        self.texto = value
    
    def get_fechahora(self):
        return self.fechahora

    def set_fechahora(self, value):
        self.fechahora = value
    
    def get_incidencia_num(self):
        return self.incidencia_num

    def set_incidencia_num(self, value):
        self.incidencia_num = value
        
    def get_personal_id(self):
        return self.personal_id

    def set_personal_id(self, value):
        self.personal_id = value    
        
    def get_adjunto_url(self):
        return self.adjunto_url

    def set_adjunto_url(self, value):
        self.adjunto_url = value
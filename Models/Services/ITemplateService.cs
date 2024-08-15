using Template_Design.shared;

namespace Template_Design.Models.Services
{
    public interface ITemplateService
    {
        public Task<IEnumerable<Template>> GetTemplates();
        public Task<Template> GetTemplateById(int templateId);
        public Task<Template> AddTemplate(Template newTemplate);
        public Task<Template> UpdateTemplate(Template updateTemplate);
        public Task DeleteTemplate(int templateId);
        

    }
}

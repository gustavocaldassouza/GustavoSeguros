import { provideHttpClient, withFetch } from '@angular/common/http';

export { AppServerModule as default } from './app/app.module.server';
provideHttpClient(withFetch());

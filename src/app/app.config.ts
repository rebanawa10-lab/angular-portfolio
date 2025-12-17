import { ApplicationConfig, provideBrowserGlobalErrorListeners, provideZoneChangeDetection } from '@angular/core';
// import { provideRouter } from '@angular/router';  // ** OLD 

import { routes } from './app.routes';
import { provideRouter, withHashLocation } from '@angular/router';  // ** NEW

export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZoneChangeDetection({ eventCoalescing: true }), 
    // provideRouter(routes)  // ** OLD 
    provideRouter(routes, withHashLocation()) // ** NEW
  ]
};

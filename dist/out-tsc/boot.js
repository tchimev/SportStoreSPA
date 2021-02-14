"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_dynamic_1 = require("@angular/platform-browser-dynamic");
var app_module_1 = require("./app/app.module");
var bootApplication = function () {
    core_1.enableProdMode();
    platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(app_module_1.AppModule);
};
// if (module["hot"]) {
//         module["hot"].accept();
//         module["hot"].dispose(() => {
//             const oldRootElem = document.querySelector("app-root");
//             const newRootElem = document.createElement("app-root");
//             oldRootElem.parentNode.insertBefore(newRootElem, oldRootElem);
//             platformBrowserDynamic().destroy();
//         });
//     }
if (document.readyState === "complete") {
    bootApplication();
}
else {
    document.addEventListener("DOMContentLoaded", bootApplication);
}
//# sourceMappingURL=boot.js.map
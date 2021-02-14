"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.OrderAdminComponent = void 0;
var core_1 = require("@angular/core");
var repository_1 = require("../models/repository");
var OrderAdminComponent = /** @class */ (function () {
    function OrderAdminComponent(repo) {
        this.repo = repo;
    }
    Object.defineProperty(OrderAdminComponent.prototype, "orders", {
        get: function () {
            return this.repo.orders;
        },
        enumerable: false,
        configurable: true
    });
    OrderAdminComponent.prototype.markShipped = function (order) {
        this.repo.shipOrder(order);
    };
    OrderAdminComponent = __decorate([
        core_1.Component({
            templateUrl: "orderAdmin.component.html"
        }),
        __metadata("design:paramtypes", [repository_1.Repository])
    ], OrderAdminComponent);
    return OrderAdminComponent;
}());
exports.OrderAdminComponent = OrderAdminComponent;
//# sourceMappingURL=orderAdmin.component.js.map
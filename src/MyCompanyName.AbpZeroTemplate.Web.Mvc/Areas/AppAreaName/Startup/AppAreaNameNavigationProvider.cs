﻿using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using MyCompanyName.AbpZeroTemplate.Authorization;

namespace MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Startup
{
    public class AppAreaNameNavigationProvider : NavigationProvider
    {
        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaName/HostDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Dashboard),
                        order: 1
                    )
                ).AddItem(new MenuItemDefinition(
                    AppAreaNamePageNames.Host.Tenants,
                    L("Tenants"),
                    url: "AppAreaName/Tenants",
                    icon: "flaticon-list-3",
                    permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants),
                    order: 2
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Host.Editions,
                        L("Editions"),
                        url: "AppAreaName/Editions",
                        icon: "flaticon-app",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Editions),
                        order: 3
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaName/TenantDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenant_Dashboard),
                        order: 1
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8",
                        order: 4
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "AppAreaName/OrganizationUnits",
                            icon: "flaticon-map",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_OrganizationUnits),
                            order: 1
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.Roles,
                            L("Roles"),
                            url: "AppAreaName/Roles",
                            icon: "flaticon-suitcase",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Roles),
                            order: 2
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.Users,
                            L("Users"),
                            url: "AppAreaName/Users",
                            icon: "flaticon-users",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Users),
                            order: 3
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.Languages,
                            L("Languages"),
                            url: "AppAreaName/Languages",
                            icon: "flaticon-tabs",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Languages),
                            order: 4
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "AppAreaName/AuditLogs",
                            icon: "flaticon-folder-1",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_AuditLogs),
                            order: 5
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "AppAreaName/Maintenance",
                            icon: "flaticon-lock",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Maintenance),
                            order: 6
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "AppAreaName/SubscriptionManagement",
                            icon: "flaticon-refresh",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement),
                            order: 6
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "AppAreaName/UiCustomization",
                            icon: "flaticon-medical",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_UiCustomization),
                            order: 7
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Host.Settings,
                            L("Settings"),
                            url: "AppAreaName/HostSettings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Settings),
                            order: 8
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Tenant.Settings,
                            L("Settings"),
                            url: "AppAreaName/Settings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_Settings),
                            order: 8
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.WebhookSubscriptions,
                            L("WebhookSubscriptions"),
                            url: "AppAreaName/WebhookSubscription",
                            icon: "flaticon2-world",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_WebhookSubscription),
                            order: 9
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.DynamicEntityParameters,
                            L("DynamicParameters"),
                            icon: "flaticon-interface-8"
                        ).AddItem(new MenuItemDefinition(
                                AppAreaNamePageNames.Common.DynamicParameters,
                                L("Definitions"),
                                url: "AppAreaName/DynamicParameter",
                                icon: "flaticon-map",
                                permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_DynamicParameters)
                            )
                        )
                        .AddItem(new MenuItemDefinition(
                                AppAreaNamePageNames.Common.EntityDynamicParameters,
                                L("EntityDynamicParameters"),
                                url: "AppAreaName/EntityDynamicParameter",
                                icon: "flaticon-map",
                                permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_EntityDynamicParameters)
                            )
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Common.DemoUiComponents,
                        L("DemoUiComponents"),
                        url: "AppAreaName/DemoUiComponents",
                        icon: "flaticon-shapes",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_DemoUiComponents),
                        order: 5
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpZeroTemplateConsts.LocalizationSourceName);
        }
    }
}

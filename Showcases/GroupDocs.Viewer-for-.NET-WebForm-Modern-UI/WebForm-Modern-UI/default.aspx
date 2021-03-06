﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebForm_Modern_UI._default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>GroupDocs.Viewer for .NET</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/angular_material/1.1.0/angular-material.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons|Roboto+Condensed:400,700">
    <link href="Content/style.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.1/angular.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.1/angular-animate.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.1/angular-aria.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.1/angular-resource.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angular_material/1.1.0/angular-material.min.js"></script>
    <script src="Content/app.js"></script>
</head>
<body>

    <div ng-app="GroupDocsViewer" ng-cloak flex layout="column" style="height: 100%;">
        <md-toolbar ng-controller="ToolbarController" layout="row" hide-print md-whiteframe="4"
                    class="md-toolbar-tools md-scroll-shrink">
            <md-button class="md-icon-button" ng-click="toggleLeft()">
                <md-icon>menu</md-icon>
            </md-button>
            <h1 hide-xs>GroupDocs.Viewer for .NET</h1>
            <span flex></span>
            <md-button ng-href="DownloadOriginal?file={{ selectedFile }}"
                       class="md-icon-button"
                       ng-disabled="!selectedFile">
                <md-icon>file_download</md-icon>
                <md-tooltip>Download</md-tooltip>
            </md-button>
            <md-button ng-href="DownloadPdf?file={{ selectedFile }}"
                       target="_blank"
                       class="md-icon-button"
                       ng-disabled="!selectedFile">
                <md-icon>picture_as_pdf</md-icon>
                <md-tooltip>Download as pdf</md-tooltip>
            </md-button>
            <div ng-controller="AvailableFilesController">
                <md-select ng-model="selectedFile" placeholder="Please select a file"
                           md-on-open="onOpen()"
                           ng-change="onChange($event)">
                    <md-optgroup label="Available files">
                        <md-option ng-value="item" ng-repeat="item in list">{{ item }}</md-option>
                    </md-optgroup>
                </md-select>
            </div>
            <md-button class="md-icon-button">
                <md-icon>more_vert</md-icon>
            </md-button>
        </md-toolbar>
        <md-content flex layout="row" md-scroll-y>
            <md-content flex id="content" class="md-padding" role="main">
                <div ng-controller="PagesController">
                    <md-card ng-repeat="item in pages">
                        <a name="page-view-{{ item.number }}"></a>
                        <iframe ng-src="{{ createPageUrl(selectedFile, item.number) }}"
                                width="100%"
                                frameborder="0"></iframe>
                    </md-card>
                </div>
            </md-content>
            <md-sidenav md-component-id="left" hide-print md-whiteframe="4" class="md-sidenav-left">
                <md-tabs md-dynamic-height md-border-bottom>
                    <md-tab label="Thumbnails">
                        <md-content role="navigation">
                            <div ng-controller="ThumbnailsController">
                                <md-card ng-repeat="item in pages">
                                    <img ng-src="{{ createThumbnailUrl(selectedFile, item.number) }}"
                                         ng-click="onThumbnailClick($event, item)"
                                         class="md-card-image page-thumbnail" />
                                </md-card>
                            </div>
                        </md-content>
                    </md-tab>
                </md-tabs>
            </md-sidenav>
        </md-content>
    </div>

</body>
</html>



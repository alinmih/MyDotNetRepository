@ModelType StratificateQCFlow.Models.ProductionOrder
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>ProductionOrder</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Order)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Order)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ReleaseDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ReleaseDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.QuantityOK)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.QuantityOK)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.QuantityNOK)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.QuantityNOK)
        </dd>
        
        <dt>
            @Html.DisplayNameFor(Function(model) model.Batch)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Batch)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.User)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.User)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
